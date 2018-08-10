using System;
using System.Collections.Generic;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Logger;
using RBTeam.Saml2Lib.Services;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.MessageProcessing
{
	// Token: 0x0200001E RID: 30
	internal class Pipeline
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00005C7A File Offset: 0x00003E7A
		internal Pipeline(ILog log)
		{
			this.stack = new List<MessageProcessingService>();
			this.logger = log;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005C94 File Offset: 0x00003E94
		internal Saml2MessageModel Process(Saml2MessageModel model)
		{
			bool flag;
			if (model == null)
			{
				flag = (null != null);
			}
			else
			{
				Saml2Config config = model.Config;
				flag = (((config != null) ? config.GlobalContext : null) != null);
			}
			if (!flag)
			{
				throw new Saml2ModuleException("model is null, or mode.Config is not filled, or model.Config.GlobalContext is not filled");
			}
			ConfigValidator.Check(model.Config);
			MetadataValidator.Check(model.Config.SpMetadata, true);
			MetadataValidator.Check(model.Config.IdpMetadata, false);
			foreach (MessageProcessingService messageProcessingService in this.stack)
			{
				messageProcessingService.ValidateModel(model);
				messageProcessingService.FireBeforeProcess(model.Message);
				messageProcessingService.Process(model);
				messageProcessingService.FireAfterProcessed(model.Message);
			}
			return model;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005D58 File Offset: 0x00003F58
		internal void WriteMsgToLog(string msg)
		{
			this.logger.Trace(msg, Array.Empty<object>());
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005D6B File Offset: 0x00003F6B
		protected void AddService(MessageProcessingService service)
		{
			this.stack.Add(service);
		}

		// Token: 0x0400003C RID: 60
		private readonly ILog logger;

		// Token: 0x0400003D RID: 61
		protected List<MessageProcessingService> stack;
	}
}
