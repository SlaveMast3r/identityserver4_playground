using System;
using RBTeam.Saml2Lib.Data.Messages;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000AE RID: 174
	public interface ISaml2Message
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004D2 RID: 1234
		// (set) Token: 0x060004D3 RID: 1235
		NameIDType Issuer { get; set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060004D4 RID: 1236
		// (set) Token: 0x060004D5 RID: 1237
		SignatureType Signature { get; set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060004D6 RID: 1238
		// (set) Token: 0x060004D7 RID: 1239
		string ID { get; set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060004D8 RID: 1240
		// (set) Token: 0x060004D9 RID: 1241
		string Version { get; set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060004DA RID: 1242
		// (set) Token: 0x060004DB RID: 1243
		DateTime IssueInstant { get; set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060004DC RID: 1244
		// (set) Token: 0x060004DD RID: 1245
		string Destination { get; set; }
	}
}
