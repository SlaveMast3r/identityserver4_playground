using System;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Logger;
using RBTeam.Saml2Lib.Services;

namespace RBTeam.Saml2Lib.MessageProcessing
{
	// Token: 0x02000020 RID: 32
	internal class SendPipeline : Pipeline, ISaml2Sender
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00005DFC File Offset: 0x00003FFC
		internal SendPipeline(ILog log) : base(log)
		{
			base.AddService(new SendMessageCreator());
			base.AddService(new SendSerializer());
			base.AddService(new SendSignature());
			base.AddService(new SendWriter());
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000C2 RID: 194 RVA: 0x00005E31 File Offset: 0x00004031
		// (remove) Token: 0x060000C3 RID: 195 RVA: 0x00005E45 File Offset: 0x00004045
		public event Action<ISaml2Message> MessageCreated
		{
			add
			{
				this.stack[0].AfterProcessed += value;
			}
			remove
			{
				this.stack[0].AfterProcessed -= value;
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000C4 RID: 196 RVA: 0x00005E59 File Offset: 0x00004059
		// (remove) Token: 0x060000C5 RID: 197 RVA: 0x00005E6D File Offset: 0x0000406D
		public event Action<ISaml2Message> BeforeResponseWrite
		{
			add
			{
				this.stack[3].BeforeProcess += value;
			}
			remove
			{
				this.stack[3].BeforeProcess -= value;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005E84 File Offset: 0x00004084
		public ISaml2Message SendMessage(Saml2MessageTypeEnum messageType, string binding, Saml2Config cfg)
		{
			Saml2MessageModel saml2MessageModel = new Saml2MessageModel
			{
				Info = new Saml2MessageInfo
				{
					Binding = binding,
					MessageType = messageType
				},
				Sender = cfg.SpMetadata,
				Receiver = cfg.IdpMetadata,
				Config = cfg
			};
			saml2MessageModel.Info.SignMessage = SendPipeline.NeedsSignature(saml2MessageModel.Info.MessageType, saml2MessageModel.Config.OutgoingMessages.SignRequest, saml2MessageModel.Config.OutgoingMessages.SignResponse);
			base.Process(saml2MessageModel);
			base.WriteMsgToLog(saml2MessageModel.MessageRaw);
			return saml2MessageModel.Message;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005F24 File Offset: 0x00004124
		private static bool NeedsSignature(Saml2MessageTypeEnum messageType, bool signRequest, bool signResponse)
		{
			return ((messageType == Saml2MessageTypeEnum.AuthnRequest || messageType == Saml2MessageTypeEnum.LogoutRequest) && signRequest) || ((messageType == Saml2MessageTypeEnum.LogoutResponse || messageType == Saml2MessageTypeEnum.Response) && signResponse);
		}
	}
}
