using System;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;

namespace RBTeam.Saml2Lib.Data.Model
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	internal class Saml2MessageModel
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00006465 File Offset: 0x00004665
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000646D File Offset: 0x0000466D
		internal Saml2Config Config { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00006476 File Offset: 0x00004676
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000647E File Offset: 0x0000467E
		internal Saml2MessageInfo Info { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00006487 File Offset: 0x00004687
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000648F File Offset: 0x0000468F
		internal EntityDescriptorType Sender { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00006498 File Offset: 0x00004698
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000064A0 File Offset: 0x000046A0
		internal EntityDescriptorType Receiver { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000064A9 File Offset: 0x000046A9
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000064B1 File Offset: 0x000046B1
		internal ISaml2Message Message { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000064BA File Offset: 0x000046BA
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000064C2 File Offset: 0x000046C2
		internal string MessageRaw { get; set; }

		// Token: 0x04000051 RID: 81
		internal byte[] UrlSignature;
	}
}
