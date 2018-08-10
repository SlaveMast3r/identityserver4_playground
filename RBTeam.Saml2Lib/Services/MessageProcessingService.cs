using System;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Model;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x02000012 RID: 18
	internal abstract class MessageProcessingService
	{
		// Token: 0x06000065 RID: 101
		internal abstract void ValidateModel(Saml2MessageModel model);

		// Token: 0x06000066 RID: 102
		internal abstract void Process(Saml2MessageModel model);

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000067 RID: 103 RVA: 0x0000375C File Offset: 0x0000195C
		// (remove) Token: 0x06000068 RID: 104 RVA: 0x00003794 File Offset: 0x00001994
		internal event Action<ISaml2Message> BeforeProcess;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000069 RID: 105 RVA: 0x000037CC File Offset: 0x000019CC
		// (remove) Token: 0x0600006A RID: 106 RVA: 0x00003804 File Offset: 0x00001A04
		internal event Action<ISaml2Message> AfterProcessed;

		// Token: 0x0600006B RID: 107 RVA: 0x00003839 File Offset: 0x00001A39
		internal void FireAfterProcessed(ISaml2Message message)
		{
			Action<ISaml2Message> afterProcessed = this.AfterProcessed;
			if (afterProcessed == null)
			{
				return;
			}
			afterProcessed(message);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000384C File Offset: 0x00001A4C
		internal void FireBeforeProcess(ISaml2Message message)
		{
			Action<ISaml2Message> beforeProcess = this.BeforeProcess;
			if (beforeProcess == null)
			{
				return;
			}
			beforeProcess(message);
		}
	}
}
