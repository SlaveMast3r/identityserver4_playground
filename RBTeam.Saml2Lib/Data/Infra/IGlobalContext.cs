using System;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000AB RID: 171
	public interface IGlobalContext
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060004B9 RID: 1209
		DateTime DateTimeNow { get; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004BA RID: 1210
		Guid NewGuid { get; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004BB RID: 1211
		ISerializer Serializer { get; }
	}
}
