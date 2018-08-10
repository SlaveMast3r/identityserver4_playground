using System;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x02000014 RID: 20
	internal class ReceiveDeserializer : MessageProcessingService
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00003AA9 File Offset: 0x00001CA9
		internal override void ValidateModel(Saml2MessageModel model)
		{
			MissingModelDataException.Check(model.Info, "model.Info");
			MissingModelDataException.Check(model.MessageRaw, "model.MessageRaw");
			MissingModelDataException.Check(model.Receiver, "model.Receiver");
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003ADC File Offset: 0x00001CDC
		internal override void Process(Saml2MessageModel model)
		{
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(model.MessageRaw);
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("error while reading received xml message: " + model.MessageRaw, innerException);
			}
			if (xmlDocument.DocumentElement == null)
			{
				throw new Saml2ModuleException("received xml is not a SAML2 message");
			}
			if (xmlDocument.DocumentElement.NamespaceURI != "urn:oasis:names:tc:SAML:2.0:protocol")
			{
				throw new Saml2ModuleException("received xml is not a SAML2 message: " + xmlDocument.DocumentElement.NamespaceURI + ":" + xmlDocument.DocumentElement.LocalName);
			}
			Saml2MessageTypeEnum saml2MessageTypeEnum;
			try
			{
				saml2MessageTypeEnum = (Saml2MessageTypeEnum)Enum.Parse(typeof(Saml2MessageTypeEnum), xmlDocument.DocumentElement.LocalName);
			}
			catch (Exception innerException2)
			{
				throw new Saml2ModuleException("message type not supported: " + xmlDocument.DocumentElement.LocalName, innerException2);
			}
			switch (saml2MessageTypeEnum)
			{
			case Saml2MessageTypeEnum.AuthnRequest:
				model.Info.ServiceType = Saml2ServiceTypeEnum.SingleSignOnService;
				model.Message = SerializationUtility.Deserialize<AuthnRequestType>(model.MessageRaw);
				break;
			case Saml2MessageTypeEnum.LogoutRequest:
				model.Info.ServiceType = Saml2ServiceTypeEnum.SingleLogoutService;
				model.Message = SerializationUtility.Deserialize<LogoutRequestType>(model.MessageRaw);
				break;
			case Saml2MessageTypeEnum.Response:
				model.Info.ServiceType = Saml2ServiceTypeEnum.AssertionConsumerService;
				model.Info.IsResponse = true;
				model.Message = SerializationUtility.Deserialize<ResponseType>(model.MessageRaw);
				break;
			case Saml2MessageTypeEnum.LogoutResponse:
				model.Info.ServiceType = Saml2ServiceTypeEnum.SingleLogoutService;
				model.Info.IsResponse = true;
				model.Message = SerializationUtility.Deserialize<LogoutResponseType>(model.MessageRaw);
				break;
			default:
				throw new Saml2ModuleException("message type not supported: " + saml2MessageTypeEnum);
			}
			model.Info.MessageType = saml2MessageTypeEnum;
			if (model.Info.IsResponse == model.Info.ReceivedIsResponse)
			{
				if (saml2MessageTypeEnum == Saml2MessageTypeEnum.Response)
				{
					ReceiveDeserializer.ProcessResponse(model.Config, model.Receiver, (ResponseType)model.Message, xmlDocument);
				}
				return;
			}
			if (model.Info.ReceivedIsResponse)
			{
				throw new Saml2ModuleException("message received inside SAMLResponse parameter is a request: " + saml2MessageTypeEnum);
			}
			throw new Saml2ModuleException("message received inside SAMLRequest paramter is a response: " + saml2MessageTypeEnum);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003D0C File Offset: 0x00001F0C
		private static void ProcessResponse(Saml2Config config, EntityDescriptorType receiver, ResponseType response, XmlDocument responseXmlDoc)
		{
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(responseXmlDoc.NameTable);
			xmlNamespaceManager.AddNamespace("zyxq987", "urn:oasis:names:tc:SAML:2.0:protocol");
			xmlNamespaceManager.AddNamespace("zyxq987asser", "urn:oasis:names:tc:SAML:2.0:assertion");
			if (response.Assertion != null)
			{
				XmlNode xmlNode = responseXmlDoc.SelectSingleNode("/zyxq987:Response/zyxq987asser:Assertion[1]", xmlNamespaceManager);
				if (xmlNode != null)
				{
					response.AssertionRaw = xmlNode.OuterXml;
				}
			}
			if (response.EncryptedAssertion == null)
			{
				return;
			}
			response.AssertionRaw = ReceiveDeserializer.Decrypt(config, receiver, response.EncryptedAssertion, responseXmlDoc, xmlNamespaceManager);
			response.Assertion = SerializationUtility.Deserialize<AssertionType>(response.AssertionRaw);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003D98 File Offset: 0x00001F98
		private static string Decrypt(Saml2Config config, EntityDescriptorType receiver, EncryptedElementType encryptedElem, XmlDocument doc, XmlNamespaceManager nsMgr)
		{
			RSACryptoServiceProvider rsacryptoServiceProvider = (RSACryptoServiceProvider)CertificateUtility.GetMetadataCertificate(config, receiver, KeyTypes.encryption, true).PrivateKey;
			string result;
			try
			{
				byte[] rgb = (byte[])encryptedElem.EncryptedKey[0].CipherData.Item;
				byte[] key = rsacryptoServiceProvider.Decrypt(rgb, false);
				Aes aes = Aes.Create();
				if (aes == null)
				{
					result = null;
				}
				else
				{
					aes.Key = key;
					EncryptedData encryptedData = new EncryptedData();
					XmlElement xmlElement = doc.SelectSingleNode("/zyxq987:Response/zyxq987asser:EncryptedAssertion[1]/node()[local-name()='EncryptedData']", nsMgr) as XmlElement;
					if (xmlElement != null)
					{
						encryptedData.LoadXml(xmlElement);
					}
					EncryptedXml encryptedXml = new EncryptedXml(doc);
					result = Encoding.UTF8.GetString(encryptedXml.DecryptData(encryptedData, aes));
				}
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("cannot decrypt encrypted assertion", innerException);
			}
			return result;
		}
	}
}
