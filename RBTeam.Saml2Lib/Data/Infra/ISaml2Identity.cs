using System;
using System.IdentityModel.Tokens;
using System.Security.Principal;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000AD RID: 173
	public interface ISaml2Identity : IIdentity
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004D1 RID: 1233
		SecurityToken BootstrapToken { get; }
	}
}
