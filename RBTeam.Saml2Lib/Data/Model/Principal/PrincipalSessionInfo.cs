using System;
using System.Collections.Generic;

namespace RBTeam.Saml2Lib.Data.Model.Principal
{
	// Token: 0x02000033 RID: 51
	[Serializable]
	public class PrincipalSessionInfo
	{
		// Token: 0x06000132 RID: 306 RVA: 0x0000657E File Offset: 0x0000477E
		public PrincipalSessionInfo()
		{
			this.Attributes = new Dictionary<string, List<string>>();
			this.Roles = new List<string>();
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000659C File Offset: 0x0000479C
		// (set) Token: 0x06000134 RID: 308 RVA: 0x000065A4 File Offset: 0x000047A4
		public string Assertion { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000065AD File Offset: 0x000047AD
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000065B5 File Offset: 0x000047B5
		public Dictionary<string, List<string>> Attributes { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000065BE File Offset: 0x000047BE
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000065C6 File Offset: 0x000047C6
		public List<string> Roles { get; set; }
	}
}
