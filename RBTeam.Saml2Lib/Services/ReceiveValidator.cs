using System;
using System.Linq;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x02000017 RID: 23
	internal class ReceiveValidator : MessageProcessingService
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00004530 File Offset: 0x00002730
		internal override void ValidateModel(Saml2MessageModel model)
		{
			MissingModelDataException.Check(model.Info, "model.Info");
			MissingModelDataException.Check(model.Info.ReceivedDestination, "model.Info.ReceivedDestination");
			MissingModelDataException.Check(model.Message, "model.Message");
			MissingModelDataException.Check(model.Sender, "model.Sender");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004584 File Offset: 0x00002784
		internal override void Process(Saml2MessageModel model)
		{
			string text = null;
			text += ReceiveValidator.ValidateSignatures(model.Info.MessageSignatureVerified, model.Info.SecondarySignatureVerified, model.Info.IsResponse, model.Info.MessageType == Saml2MessageTypeEnum.Response && ((ResponseType)model.Message).Assertion != null, model.Config.IncomingMessages.WantRequestSinged, model.Config.IncomingMessages.WantResponseSinged, model.Config.IncomingMessages.WantAssertionSigned);
			text += ReceiveValidator.ValidateVersion(model.Message.Version);
			string receiverDestinationByServiceType = MetadataUtility.GetReceiverDestinationByServiceType(model.Receiver, model.Info.ServiceType, model.Info.Binding, model.Info.IsResponse);
			text += this.ValidateDestination(model.Info.ReceivedDestination, model.Message.Destination, receiverDestinationByServiceType, model.Info.ServiceType, model.Info.Binding, model.Config.IncomingMessages.ValidateHttpHttps);
			text += ReceiveValidator.ValidateIssueInstant(model.Config.GlobalContext.DateTimeNow, model.Message.IssueInstant, model.Config.TimeToleranceSeconds, model.Config.IncomingMessages.MaxMessageAgeSeconds);
			text += ReceiveValidator.ValidateIssuer(model.Message.Issuer, model.Sender.entityID);
			ResponseType responseType = model.Message as ResponseType;
			if (responseType != null)
			{
				string responseStatus = MessageUtility.GetResponseStatus((ResponseType)model.Message);
				if (responseStatus == "urn:oasis:names:tc:SAML:2.0:status:Success")
				{
					AssertionType assertion = responseType.Assertion;
					text += this.ValidateAssertion(assertion, model.Config.GlobalContext.DateTimeNow, model.Config.TimeToleranceSeconds, model.Config.IncomingMessages.MaxMessageAgeSeconds, model.Sender.entityID, model.Info.ReceivedDestination, model.Config.IncomingMessages.ValidateHttpHttps, model.Receiver.entityID);
				}
				else if (!MessageUtility.HasNoPassiveStatusCode((ResponseType)model.Message))
				{
					throw new ResponseNotSuccessException(responseStatus);
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			text = model.Info.MessageType + " validation error: " + text;
			throw new Saml2ModuleException(text);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000047F0 File Offset: 0x000029F0
		private string ValidateAssertion(AssertionType assertion, DateTime now, int timeTolerance, int maxMessageAge, string expectedIssuer, string destination, bool validateHttpHttps, string receiverEntityId)
		{
			string text = null;
			if (assertion == null)
			{
				return "Response message doesn't contain an Assertion";
			}
			text += ReceiveValidator.ValidateVersion(assertion.Version);
			text += ReceiveValidator.ValidateIssueInstant(now, assertion.IssueInstant, timeTolerance, maxMessageAge);
			string text2 = ReceiveValidator.ValidateRequiredFields(assertion);
			if (string.IsNullOrEmpty(text2))
			{
				text += ReceiveValidator.ValidateIssuer(assertion.Issuer, expectedIssuer);
				SubjectConfirmationDataType subjectConfirmationData = assertion.Subject.SubjectConfirmation.SubjectConfirmationData;
				if (subjectConfirmationData.NotBeforeSpecified)
				{
					text += ReceiveValidator.ValidateNotBefore(now, subjectConfirmationData.NotBefore, timeTolerance, "SubjectConfirationData NotBefore");
				}
				if (subjectConfirmationData.NotOnOrAfterSpecified)
				{
					text += ReceiveValidator.ValidateNotOnOrAfter(now, subjectConfirmationData.NotOnOrAfter, timeTolerance, "SubjectConfirationData NotOnOrAfter");
				}
				if (subjectConfirmationData.Recipient != null)
				{
					text += this.ValidateRecipient(destination, subjectConfirmationData.Recipient, validateHttpHttps);
				}
				text += ReceiveValidator.ValidateNotBefore(now, assertion.AuthnStatement.AuthnInstant, timeTolerance, "AuthnStatement AuthnInstant");
			}
			else
			{
				text = text + text2 + Environment.NewLine + Environment.NewLine;
			}
			if (assertion.Conditions != null)
			{
				if (assertion.Conditions.NotBeforeSpecified)
				{
					text += ReceiveValidator.ValidateNotBefore(now, assertion.Conditions.NotBefore, timeTolerance, "Conditions NotBefore");
				}
				if (assertion.Conditions.NotOnOrAfterSpecified)
				{
					text += ReceiveValidator.ValidateNotOnOrAfter(now, assertion.Conditions.NotOnOrAfter, timeTolerance, "Conditions NotOnOrAfter");
				}
				AudienceRestrictionType audienceRestriction = assertion.Conditions.AudienceRestriction;
				if (((audienceRestriction != null) ? audienceRestriction.Audience : null) != null)
				{
					text += ReceiveValidator.ValidateAudienceRestriction(receiverEntityId, assertion.Conditions.AudienceRestriction.Audience);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text = "Assertion validation error: " + text;
			}
			return text;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000049A7 File Offset: 0x00002BA7
		private static string ValidateVersion(string version)
		{
			if (version != "2.0")
			{
				return "message version is not 2.0: " + version + Environment.NewLine;
			}
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000049C8 File Offset: 0x00002BC8
		private string ValidateDestination(string received, string expected, string fromMetadata, Saml2ServiceTypeEnum serviceType, string binding, bool validateHttpHttps)
		{
			string destinationUrl = ReceiveValidator.GetDestinationUrl(received, validateHttpHttps);
			string destinationUrl2 = ReceiveValidator.GetDestinationUrl(expected, validateHttpHttps);
			string destinationUrl3 = ReceiveValidator.GetDestinationUrl(fromMetadata, validateHttpHttps);
			if (destinationUrl != destinationUrl2)
			{
				return string.Concat(new string[]
				{
					"message destination differs from request url:message destination: ",
					destinationUrl2,
					Environment.NewLine,
					"actual request url : ",
					destinationUrl,
					Environment.NewLine
				});
			}
			if (destinationUrl != destinationUrl3)
			{
				return string.Concat(new object[]
				{
					"message destination differs from metadata url: service ",
					serviceType,
					" and binding ",
					binding,
					"message destination: ",
					destinationUrl2,
					Environment.NewLine,
					"metadata destination: ",
					destinationUrl3,
					Environment.NewLine
				});
			}
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004A8C File Offset: 0x00002C8C
		private static string ValidateIssueInstant(DateTime now, DateTime issueInstant, int timeTolerance, int maxMessgeAge)
		{
			now = now.ToUniversalTime();
			issueInstant = issueInstant.ToUniversalTime();
			TimeSpan t = TimeSpan.FromSeconds((double)timeTolerance);
			TimeSpan t2 = TimeSpan.FromSeconds((double)maxMessgeAge);
			DateTime t3 = issueInstant - t;
			DateTime t4 = issueInstant + t2 + t;
			if (now >= t3 && now <= t4)
			{
				return null;
			}
			string text = (now < t3) ? "in the future" : "in the past";
			return string.Concat(new object[]
			{
				"message creation time is ",
				text,
				Environment.NewLine,
				"IssueInstant: ",
				issueInstant.ToString("yyyy.MM.dd HH:mm:ss.fff UTC"),
				Environment.NewLine,
				ReceiveValidator.GetLocalTimeInfo(now, timeTolerance),
				", message validity ",
				maxMessgeAge,
				Environment.NewLine,
				Environment.NewLine
			});
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004B6C File Offset: 0x00002D6C
		private static string ValidateIssuer(NameIDType nameIdType, string expected)
		{
			if (nameIdType == null)
			{
				return "message Issuer is missing" + Environment.NewLine;
			}
			if (nameIdType.Value != expected)
			{
				return string.Concat(new string[]
				{
					"message Issuer does not match metadata:",
					Environment.NewLine,
					"message Issuer: ",
					nameIdType.Value,
					"metadata entityID: ",
					expected,
					Environment.NewLine
				});
			}
			return null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004BDC File Offset: 0x00002DDC
		private static string ValidateSignatures(bool messageSigned, bool secondaryMessageSigned, bool isResponse, bool isAssertion, bool wantRequestSigned, bool wantResponseSigned, bool wantAssertionSigned)
		{
			if (isResponse)
			{
				if (wantResponseSigned && !messageSigned)
				{
					return "response message signature is invalid, or the message is not signed. " + Environment.NewLine + "If certificate validation is turned on in config(incomingMessages - validateIdpCert), check if the signing certificate si considered valid on the SP machine" + Environment.NewLine;
				}
				if (isAssertion && wantAssertionSigned && !secondaryMessageSigned)
				{
					return "response Assertion signature is invalid, or the Assertion is not signed" + Environment.NewLine + "If certificate validation is turned on in config(incomingMessages - validateIdpCert), check if the signing certificate si considered valid on the SP machine" + Environment.NewLine;
				}
			}
			else if (wantRequestSigned && !messageSigned)
			{
				return "request signature is invalid, or the request is not signed" + Environment.NewLine + "If certificate validation is turned on in config(incomingMessages - validateIdpCert), check if the signing certificate si considered valid on the SP machine" + Environment.NewLine;
			}
			return null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004C52 File Offset: 0x00002E52
		private static string RemoveUrlHttpProtocol(string url)
		{
			if (url.StartsWith("http://"))
			{
				return url.Substring("http://".Length);
			}
			if (!url.StartsWith("https://"))
			{
				return url;
			}
			return url.Substring("https://".Length);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004C94 File Offset: 0x00002E94
		private static string GetDestinationUrl(string url, bool validateHttpHttps)
		{
			string text = new Uri(url).GetLeftPart(UriPartial.Path);
			if (!validateHttpHttps)
			{
				text = ReceiveValidator.RemoveUrlHttpProtocol(text);
			}
			return text;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004CBC File Offset: 0x00002EBC
		private static string ValidateRequiredFields(AssertionType assertion)
		{
			if (assertion.Issuer == null)
			{
				return "assertion issuer is missing";
			}
			if (assertion.Subject == null)
			{
				return "assertion Subject is missing";
			}
			NameIDType nameID = assertion.Subject.NameID;
			if (string.IsNullOrEmpty((nameID != null) ? nameID.Value : null))
			{
				return "assertion Subject NameID is missing or has no value";
			}
			if (string.IsNullOrEmpty(assertion.Subject.NameID.Format))
			{
				return "assertion Subject NameID Format is missing or has no value";
			}
			if (string.IsNullOrEmpty(assertion.Subject.NameID.NameQualifier))
			{
				return "assertion Subject NameID NameQualifier is missing or has no value";
			}
			if (string.IsNullOrEmpty(assertion.Subject.NameID.SPNameQualifier))
			{
				return "assertion Subject NameID SPNameQualifier is missing or has no value";
			}
			if (assertion.Subject.SubjectConfirmation == null)
			{
				return "assertion Subject has no SubjectConfirmation";
			}
			if (assertion.Subject.SubjectConfirmation.SubjectConfirmationData == null)
			{
				return "assertion SubjectConfirmation has no SubjectConfirmationData";
			}
			if (assertion.AuthnStatement == null)
			{
				return "assertion AuthnStatement is missing";
			}
			if (assertion.AuthnStatement.AuthnInstant == DateTime.MinValue)
			{
				return "assertion AuthnStatement AuthnInstant is missing or empty";
			}
			if (assertion.AuthnStatement.AuthnContext == null)
			{
				return "assertion AuthnStatement has no AuthnContext";
			}
			if (string.IsNullOrEmpty(assertion.AuthnStatement.SessionIndex))
			{
				return "assertion AuthnStatement SessionIndex is empty";
			}
			if (assertion.AuthnStatement.AuthnContext.Items == null || assertion.AuthnStatement.AuthnContext.Items.Length == 0)
			{
				return "assertion AuthnStatement AuthnContext is empty";
			}
			return null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004E10 File Offset: 0x00003010
		private static string ValidateNotOnOrAfter(DateTime now, DateTime value, int timeTolerance, string propertyName)
		{
			now = now.ToUniversalTime();
			value = value.ToUniversalTime();
			TimeSpan t = TimeSpan.FromSeconds((double)timeTolerance);
			if (now >= value + t)
			{
				return string.Concat(new string[]
				{
					propertyName,
					" is in the past:",
					Environment.NewLine,
					"value: ",
					value.ToString("yyyy.MM.dd HH:mm:ss.fff UTC"),
					Environment.NewLine,
					ReceiveValidator.GetLocalTimeInfo(now, timeTolerance),
					Environment.NewLine,
					Environment.NewLine
				});
			}
			return null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004EA4 File Offset: 0x000030A4
		private static string ValidateNotBefore(DateTime now, DateTime value, int timeTolerance, string propertyName)
		{
			now = now.ToUniversalTime();
			value = value.ToUniversalTime();
			TimeSpan t = TimeSpan.FromSeconds((double)timeTolerance);
			if (now < value - t)
			{
				return string.Concat(new string[]
				{
					propertyName,
					" is in the future:",
					Environment.NewLine,
					"value: ",
					value.ToString("yyyy.MM.dd HH:mm:ss.fff UTC"),
					Environment.NewLine,
					ReceiveValidator.GetLocalTimeInfo(now, timeTolerance),
					Environment.NewLine,
					Environment.NewLine
				});
			}
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004F38 File Offset: 0x00003138
		private string ValidateRecipient(string destination, string recipient, bool validateHttpHttps)
		{
			string destinationUrl = ReceiveValidator.GetDestinationUrl(recipient, validateHttpHttps);
			string destinationUrl2 = ReceiveValidator.GetDestinationUrl(destination, validateHttpHttps);
			if (destinationUrl != destinationUrl2)
			{
				return string.Concat(new string[]
				{
					"SubjectConfirationData Recipient doesn't match the message destination:",
					Environment.NewLine,
					"recipient: ",
					destinationUrl,
					Environment.NewLine,
					"message destination: ",
					destinationUrl2,
					Environment.NewLine,
					Environment.NewLine
				});
			}
			return null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004FAC File Offset: 0x000031AC
		private static string GetLocalTimeInfo(DateTime now, int timeTolerance)
		{
			return string.Concat(new object[]
			{
				"local time is ",
				now.ToString("yyyy.MM.dd HH:mm:ss.fff UTC"),
				", time toleracne ",
				timeTolerance,
				" seconds"
			});
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004FEC File Offset: 0x000031EC
		private static string ValidateAudienceRestriction(string receiverEntityId, string[] audienceRestriction)
		{
			if (!audienceRestriction.Contains(receiverEntityId))
			{
				string[] array = new string[9];
				array[0] = "Audience restriction doesn't match receiver entityID: ";
				array[1] = Environment.NewLine;
				array[2] = "Audience restriction: ";
				array[3] = audienceRestriction.Aggregate((string result, string item) => result + ", " + item);
				array[4] = Environment.NewLine;
				array[5] = "Receiver entityID: ";
				array[6] = receiverEntityId;
				array[7] = Environment.NewLine;
				array[8] = Environment.NewLine;
				return string.Concat(array);
			}
			return null;
		}
	}
}
