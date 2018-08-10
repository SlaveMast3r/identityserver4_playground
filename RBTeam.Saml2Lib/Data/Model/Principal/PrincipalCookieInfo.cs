using System;
using System.Collections.Generic;

namespace RBTeam.Saml2Lib.Data.Model.Principal
{
	// Token: 0x02000032 RID: 50
	[Serializable]
	public class PrincipalCookieInfo
	{
		// Token: 0x0600012F RID: 303 RVA: 0x0000655A File Offset: 0x0000475A
		public PrincipalCookieInfo()
		{
			this.Roles = new List<string>();
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000656D File Offset: 0x0000476D
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00006575 File Offset: 0x00004775
		public List<string> Roles { get; set; }
	}
}
