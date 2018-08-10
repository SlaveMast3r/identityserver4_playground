using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x0200001A RID: 26
	internal class SendSignature : MessageProcessingService
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00005378 File Offset: 0x00003578
		internal override void ValidateModel(Saml2MessageModel model)
		{
			MissingModelDataException.Check(model.Info, "model.Info");
			MissingModelDataException.Check(model.Info.Binding, "model.Info.Binding");
			MissingModelDataException.Check(model.MessageRaw, "model.MessageRaw");
			MissingModelDataException.Check(model.Sender, "model.Sender");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000053CC File Offset: 0x000035CC
		internal override void Process(Saml2MessageModel model)
		{
			if (!model.Info.SignMessage)
			{
				return;
			}
			try
			{
				X509Certificate2 metadataCertificate = CertificateUtility.GetMetadataCertificate(model.Config, model.Sender, KeyTypes.signing, true);
				string binding = model.Info.Binding;
				if (!(binding == "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST"))
				{
					if (!(binding == "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"))
					{
						throw new Saml2ModuleException("unsupported binding type: " + model.Info.Binding);
					}
					string redirectQueryStringWithSignAlg = BindingUtility.GetRedirectQueryStringWithSignAlg(model.Config.HttpContext, model.MessageRaw, model.Info.IsResponse);
					model.UrlSignature = SendSignature.SignString(metadataCertificate, redirectQueryStringWithSignAlg);
				}
				else
				{
					XmlDocument xmlDocument = SendSignature.SignXml(metadataCertificate, model.MessageRaw);
					model.MessageRaw = xmlDocument.OuterXml;
				}
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("error while signing saml message", innerException);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000054AC File Offset: 0x000036AC
		private static XmlDocument SignXml(X509Certificate2 cert, string xml)
		{
			RSACryptoServiceProvider signingKey = (RSACryptoServiceProvider)cert.PrivateKey;
			Reference reference = new Reference
			{
				Uri = string.Empty
			};
			reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
			reference.AddTransform(new XmlDsigExcC14NTransform());
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			SignedXml signedXml = new SignedXml(xmlDocument)
			{
				SigningKey = signingKey
			};
			signedXml.KeyInfo.AddClause(new KeyInfoX509Data(cert));
			signedXml.AddReference(reference);
			signedXml.ComputeSignature();
			XmlElement documentElement = xmlDocument.DocumentElement;
			if (documentElement == null)
			{
				return xmlDocument;
			}
			documentElement.AppendChild(signedXml.GetXml());
			return xmlDocument;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000553C File Offset: 0x0000373C
		private static byte[] SignString(X509Certificate2 cert, string str)
		{
			RSAPKCS1SignatureFormatter rsapkcs1SignatureFormatter = new RSAPKCS1SignatureFormatter((RSACryptoServiceProvider)cert.PrivateKey);
			rsapkcs1SignatureFormatter.SetHashAlgorithm("SHA");
			SHA1Managed sha1Managed = new SHA1Managed();
			return rsapkcs1SignatureFormatter.CreateSignature(sha1Managed.ComputeHash(Encoding.UTF8.GetBytes(str)));
		}
	}
}
