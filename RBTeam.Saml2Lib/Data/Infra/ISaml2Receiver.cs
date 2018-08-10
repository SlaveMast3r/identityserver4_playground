using System;
using RBTeam.Saml2Lib.Configuration;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000B0 RID: 176
	public interface ISaml2Receiver
	{
		// Token: 0x060004E6 RID: 1254
		ISaml2Message ReadMessage(Saml2Config cfg);
	}
}
