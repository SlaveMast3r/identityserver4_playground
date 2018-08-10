using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000AF RID: 175
	public interface ISaml2Principal : IPrincipal
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060004DE RID: 1246
		string NameID { get; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004DF RID: 1247
		string NameIDFormat { get; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004E0 RID: 1248
		string NameIDIdp { get; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004E1 RID: 1249
		string NameIDSp { get; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004E2 RID: 1250
		string SessionIndex { get; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004E3 RID: 1251
		IDictionary<string, IEnumerable<string>> Claims { get; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060004E4 RID: 1252
		string Assertion { get; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060004E5 RID: 1253
		IEnumerable<string> Roles { get; }
	}
}
