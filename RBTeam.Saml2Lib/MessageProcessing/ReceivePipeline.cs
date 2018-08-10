using System;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Logger;
using RBTeam.Saml2Lib.Services;

namespace RBTeam.Saml2Lib.MessageProcessing
{
	// Token: 0x0200001F RID: 31
	internal class ReceivePipeline : Pipeline, ISaml2Receiver
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00005D79 File Offset: 0x00003F79
		internal ReceivePipeline(ILog log) : base(log)
		{
			base.AddService(new ReceiveReader());
			base.AddService(new ReceiveDeserializer());
			base.AddService(new ReceiveSignature());
			base.AddService(new ReceiveValidator());
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005DB0 File Offset: 0x00003FB0
		public ISaml2Message ReadMessage(Saml2Config cfg)
		{
			Saml2MessageModel saml2MessageModel = new Saml2MessageModel
			{
				Sender = cfg.IdpMetadata,
				Receiver = cfg.SpMetadata,
				Config = cfg
			};
			base.Process(saml2MessageModel);
			base.WriteMsgToLog(saml2MessageModel.MessageRaw);
			return saml2MessageModel.Message;
		}
	}
}
