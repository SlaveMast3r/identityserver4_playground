using System;
using RBTeam.Saml2Lib.Configuration;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000B2 RID: 178
	public interface ISaml2Sender
	{
		// Token: 0x060004ED RID: 1261
		ISaml2Message SendMessage(Saml2MessageTypeEnum messageType, string binding, Saml2Config cfg);

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060004EE RID: 1262
		// (remove) Token: 0x060004EF RID: 1263
		event Action<ISaml2Message> MessageCreated;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060004F0 RID: 1264
		// (remove) Token: 0x060004F1 RID: 1265
		event Action<ISaml2Message> BeforeResponseWrite;
	}
}
