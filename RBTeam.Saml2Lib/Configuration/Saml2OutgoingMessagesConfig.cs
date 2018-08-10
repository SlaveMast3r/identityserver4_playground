using System;
using System.Configuration;

namespace RBTeam.Saml2Lib.Configuration
{
	// Token: 0x020000C0 RID: 192
	public class Saml2OutgoingMessagesConfig : ConfigurationElement
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00009821 File Offset: 0x00007A21
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00009833 File Offset: 0x00007A33
		[ConfigurationProperty("signRequest", DefaultValue = true, IsRequired = false)]
		public bool SignRequest
		{
			get
			{
				return (bool)base["signRequest"];
			}
			set
			{
				base["signRequest"] = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00009846 File Offset: 0x00007A46
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00009858 File Offset: 0x00007A58
		[ConfigurationProperty("signResponse", DefaultValue = true, IsRequired = false)]
		public bool SignResponse
		{
			get
			{
				return (bool)base["signResponse"];
			}
			set
			{
				base["signResponse"] = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0000986B File Offset: 0x00007A6B
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x0000987D File Offset: 0x00007A7D
		[ConfigurationProperty("requestedAuthnContext")]
		public string RequestedAuthnContext
		{
			get
			{
				return base["requestedAuthnContext"].ToString();
			}
			set
			{
				base["requestedAuthnContext"] = value;
			}
		}
	}
}
