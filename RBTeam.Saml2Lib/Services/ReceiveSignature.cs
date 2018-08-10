using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02000016 RID: 22
	internal class ReceiveSignature : MessageProcessingService
	{
		// Token: 0x0600007F RID: 127 RVA: 0x000040DC File Offset: 0x000022DC
		internal override void ValidateModel(Saml2MessageModel model)
		{
			MissingModelDataException.Check(model.Info, "model.Info");
			MissingModelDataException.Check(model.Info.Binding, "model.Info.Binding");
			MissingModelDataException.Check(model.Info.ReceivedDestination, "model.Info.ReceivedDestination");
			MissingModelDataException.Check(model.MessageRaw, "model.MessageRaw");
			MissingModelDataException.Check(model.Sender, "model.Sender");
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004144 File Offset: 0x00002344
		internal override void Process(Saml2MessageModel model)
		{
			X509Certificate2 metadataCertificate = CertificateUtility.GetMetadataCertificate(model.Config, model.Sender, KeyTypes.signing, false);
			string binding = model.Info.Binding;
			if (!(binding == "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST"))
			{
				if (!(binding == "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"))
				{
					throw new Saml2ModuleException("binding not supported: " + model.Info.Binding);
				}
				model.Info.MessageSignatureVerified = ReceiveSignature.VerifyUrlSignature(metadataCertificate, model.Info.ReceivedDestination, model.UrlSignature, model.Config.IncomingMessages.ValidateIdpCert);
			}
			else
			{
				model.Info.MessageSignatureVerified = this.VerifyTopXmlSignature(metadataCertificate, model.MessageRaw, model.Config.IncomingMessages.ValidateIdpCert);
			}
			model.Info.SecondarySignatureVerified = this.VerifyAssertionSignature(model.Message as ResponseType, metadataCertificate, model.Config.IncomingMessages.ValidateIdpCert);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004233 File Offset: 0x00002433
		private bool VerifyAssertionSignature(ResponseType response, X509Certificate2 cert, bool validateIdpCert)
		{
			return !string.IsNullOrEmpty((response != null) ? response.AssertionRaw : null) && this.VerifyTopXmlSignature(cert, response.AssertionRaw, validateIdpCert);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004258 File Offset: 0x00002458
		private bool VerifyTopXmlSignature(X509Certificate2 cert, string xml, bool validateCert)
		{
			bool result;
			try
			{
				XmlDocument xmlDocument = new XmlDocument
				{
					PreserveWhitespace = true
				};
				xmlDocument.LoadXml(xml);
				XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
				xmlNamespaceManager.AddNamespace("zyxq987", "urn:oasis:names:tc:SAML:2.0:protocol");
				xmlNamespaceManager.AddNamespace("zyxq987dsig", "http://www.w3.org/2000/09/xmldsig#");
				XmlElement xmlElement = this.VerifySignatureIntegrity(xmlDocument);
				if (xmlElement == null)
				{
					result = false;
				}
				else
				{
					SignedXml signedXml = new SignedXml(xmlDocument);
					signedXml.LoadXml(xmlElement);
					bool flag = signedXml.CheckSignature(cert, true);
					if (validateCert)
					{
						flag &= CertificateUtility.ValidateCertificate(cert);
					}
					result = flag;
				}
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("Error while verifying xml message signature", innerException);
			}
			return result;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000042F8 File Offset: 0x000024F8
		private XmlElement VerifySignatureIntegrity(XmlDocument doc)
		{
			IList<XmlElement> childElements = ReceiveSignature.GetChildElements(doc.DocumentElement, "Signature", "http://www.w3.org/2000/09/xmldsig#");
			if (childElements.Count != 1)
			{
				return null;
			}
			IList<XmlElement> childElements2 = ReceiveSignature.GetChildElements(childElements[0], "SignedInfo", "http://www.w3.org/2000/09/xmldsig#");
			if (childElements2.Count != 1)
			{
				return null;
			}
			IList<XmlElement> childElements3 = ReceiveSignature.GetChildElements(childElements2[0], "Reference", "http://www.w3.org/2000/09/xmldsig#");
			if (childElements3.Count != 1)
			{
				return null;
			}
			string value = childElements3[0].Attributes["URI"].Value;
			if (doc.DocumentElement == null)
			{
				return childElements[0];
			}
			string b = "#" + doc.DocumentElement.Attributes["ID"].Value;
			if (value != string.Empty && value != b)
			{
				return null;
			}
			return childElements[0];
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000043DC File Offset: 0x000025DC
		private static bool VerifyUrlSignature(X509Certificate2 cert, string url, byte[] signature, bool validateCertificate)
		{
			if (signature == null)
			{
				return false;
			}
			string text;
			try
			{
				text = new Uri(url).Query.Substring(1);
				text = (from param in text.Split(new char[]
				{
					'&'
				})
				where param.StartsWith("Signature=")
				select param).Aggregate(text, (string current, string param) => current.Replace("&" + param, string.Empty));
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("url malformed: " + url, innerException);
			}
			bool flag;
			try
			{
				RSAPKCS1SignatureDeformatter rsapkcs1SignatureDeformatter = new RSAPKCS1SignatureDeformatter(cert.PublicKey.Key);
				rsapkcs1SignatureDeformatter.SetHashAlgorithm("SHA");
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				flag = rsapkcs1SignatureDeformatter.VerifySignature(new SHA1Managed().ComputeHash(bytes), signature);
			}
			catch (Exception innerException2)
			{
				throw new Saml2ModuleException("error while verifying url signature: " + url, innerException2);
			}
			if (validateCertificate)
			{
				flag &= CertificateUtility.ValidateCertificate(cert);
			}
			return flag;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000044EC File Offset: 0x000026EC
		private static IList<XmlElement> GetChildElements(XmlNode parent, string localName, string ns)
		{
			return (from child in parent.ChildNodes.OfType<XmlElement>()
			where child.LocalName == localName && child.NamespaceURI == ns
			select child).ToList<XmlElement>();
		}
	}
}
