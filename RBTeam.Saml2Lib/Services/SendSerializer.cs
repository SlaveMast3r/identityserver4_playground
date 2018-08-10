using System;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x02000019 RID: 25
	internal class SendSerializer : MessageProcessingService
	{
		// Token: 0x0600009B RID: 155 RVA: 0x000052A4 File Offset: 0x000034A4
		internal override void ValidateModel(Saml2MessageModel model)
		{
			MissingModelDataException.Check(model.Info, "model.Info");
			MissingModelDataException.Check(model.Info.MessageType, "model.Info.MessageType");
			MissingModelDataException.Check(model.Message, "model.Message");
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000052E0 File Offset: 0x000034E0
		internal override void Process(Saml2MessageModel model)
		{
			switch (model.Info.MessageType)
			{
			case Saml2MessageTypeEnum.AuthnRequest:
				model.MessageRaw = SerializationUtility.Serialize<AuthnRequestType>(model.Message);
				return;
			case Saml2MessageTypeEnum.LogoutRequest:
				model.MessageRaw = SerializationUtility.Serialize<LogoutRequestType>(model.Message);
				return;
			case Saml2MessageTypeEnum.Response:
				model.MessageRaw = SerializationUtility.Serialize<ResponseType>(model.Message);
				return;
			case Saml2MessageTypeEnum.LogoutResponse:
				model.MessageRaw = SerializationUtility.Serialize<LogoutResponseType>(model.Message);
				return;
			default:
				throw new Saml2ModuleException("message type not supported: " + model.Info.MessageType);
			}
		}
	}
}
