using System;
using RBTeam.Saml2Lib.Data.Infra;

namespace RBTeam.Saml2Lib.Data.Model
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	internal class Saml2MessageInfo
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000063CC File Offset: 0x000045CC
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000063D4 File Offset: 0x000045D4
		internal Saml2MessageTypeEnum MessageType { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000063DD File Offset: 0x000045DD
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000063E5 File Offset: 0x000045E5
		internal bool IsResponse { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000063EE File Offset: 0x000045EE
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000063F6 File Offset: 0x000045F6
		internal Saml2ServiceTypeEnum ServiceType { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000063FF File Offset: 0x000045FF
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00006407 File Offset: 0x00004607
		internal string Binding { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00006410 File Offset: 0x00004610
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00006418 File Offset: 0x00004618
		internal string ReceivedDestination { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00006421 File Offset: 0x00004621
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00006429 File Offset: 0x00004629
		internal bool ReceivedIsResponse { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00006432 File Offset: 0x00004632
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000643A File Offset: 0x0000463A
		internal bool SignMessage { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006443 File Offset: 0x00004643
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000644B File Offset: 0x0000464B
		internal bool MessageSignatureVerified { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006454 File Offset: 0x00004654
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000645C File Offset: 0x0000465C
		internal bool SecondarySignatureVerified { get; set; }
	}
}
