using System;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x02000018 RID: 24
	internal class SendMessageCreator : MessageProcessingService
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00005074 File Offset: 0x00003274
		internal override void ValidateModel(Saml2MessageModel model)
		{
			MissingModelDataException.Check(model.Info, "model.Info");
			MissingModelDataException.Check(model.Info.Binding, "model.Info.Binding");
			MissingModelDataException.Check(model.Sender, "model.Sender");
			MissingModelDataException.Check(model.Receiver, "model.Receiver");
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000050C8 File Offset: 0x000032C8
		internal override void Process(Saml2MessageModel model)
		{
			switch (model.Info.MessageType)
			{
			case Saml2MessageTypeEnum.AuthnRequest:
				model.Message = new AuthnRequestType();
				model.Info.ServiceType = Saml2ServiceTypeEnum.SingleSignOnService;
				if (!string.IsNullOrEmpty(model.Config.OutgoingMessages.RequestedAuthnContext))
				{
					RequestedAuthnContextType requestedAuthnContext = new RequestedAuthnContextType
					{
						Comparison = AuthnContextComparisonType.minimum,
						ComparisonSpecified = true,
						ItemsElementName = new AuthnContextRefType[1],
						Items = new string[]
						{
							model.Config.OutgoingMessages.RequestedAuthnContext
						}
					};
					((AuthnRequestType)model.Message).RequestedAuthnContext = requestedAuthnContext;
				}
				break;
			case Saml2MessageTypeEnum.LogoutRequest:
				model.Message = new LogoutRequestType();
				model.Info.ServiceType = Saml2ServiceTypeEnum.SingleLogoutService;
				break;
			case Saml2MessageTypeEnum.Response:
				model.Message = new ResponseType();
				model.Info.ServiceType = Saml2ServiceTypeEnum.AssertionConsumerService;
				model.Info.IsResponse = true;
				break;
			case Saml2MessageTypeEnum.LogoutResponse:
				model.Message = new LogoutResponseType();
				model.Info.ServiceType = Saml2ServiceTypeEnum.SingleLogoutService;
				model.Info.IsResponse = true;
				break;
			default:
				throw new Saml2ModuleException("unsupported message type: " + model.Info.MessageType);
			}
			model.Message.ID = "_" + model.Config.GlobalContext.NewGuid;
			model.Message.IssueInstant = model.Config.GlobalContext.DateTimeNow;
			model.Message.Issuer = new NameIDType
			{
				Value = model.Sender.entityID
			};
			model.Message.Destination = MetadataUtility.GetReceiverDestinationByServiceType(model.Receiver, model.Info.ServiceType, model.Info.Binding, model.Info.IsResponse);
		}
	}
}
