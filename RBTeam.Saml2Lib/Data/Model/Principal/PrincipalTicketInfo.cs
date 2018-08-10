using System;

namespace RBTeam.Saml2Lib.Data.Model.Principal
{
	// Token: 0x02000034 RID: 52
	[Serializable]
	public class PrincipalTicketInfo
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000065CF File Offset: 0x000047CF
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000065D7 File Offset: 0x000047D7
		public string Username { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000065E0 File Offset: 0x000047E0
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000065E8 File Offset: 0x000047E8
		public string AuthnType { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000065F1 File Offset: 0x000047F1
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000065F9 File Offset: 0x000047F9
		public string SessionIndex { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00006602 File Offset: 0x00004802
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000660A File Offset: 0x0000480A
		public string Id { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00006613 File Offset: 0x00004813
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000661B File Offset: 0x0000481B
		public string IdFormat { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006624 File Offset: 0x00004824
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000662C File Offset: 0x0000482C
		public string IdIdp { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00006635 File Offset: 0x00004835
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000663D File Offset: 0x0000483D
		public string IdSp { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006646 File Offset: 0x00004846
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000664E File Offset: 0x0000484E
		public DateTime ValidTo { get; set; }
	}
}
