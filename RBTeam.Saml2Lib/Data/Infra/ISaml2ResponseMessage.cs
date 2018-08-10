using System;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000B1 RID: 177
	public interface ISaml2ResponseMessage : ISaml2Message
	{
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060004E7 RID: 1255
		// (set) Token: 0x060004E8 RID: 1256
		string InResponseTo { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060004E9 RID: 1257
		// (set) Token: 0x060004EA RID: 1258
		string StatusCode { get; set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004EB RID: 1259
		// (set) Token: 0x060004EC RID: 1260
		string SecondLevelStatusCode { get; set; }
	}
}
