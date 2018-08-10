using System;
using System.Configuration;

namespace RBTeam.Saml2Lib.Configuration
{
	// Token: 0x020000BF RID: 191
	public class Saml2IncomingMessagesConfig : ConfigurationElement
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00009743 File Offset: 0x00007943
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00009755 File Offset: 0x00007955
		[ConfigurationProperty("wantRequestSinged", DefaultValue = true, IsRequired = false)]
		public bool WantRequestSinged
		{
			get
			{
				return (bool)base["wantRequestSinged"];
			}
			set
			{
				base["wantRequestSinged"] = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00009768 File Offset: 0x00007968
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x0000977A File Offset: 0x0000797A
		[ConfigurationProperty("wantResponseSinged", DefaultValue = true, IsRequired = false)]
		public bool WantResponseSinged
		{
			get
			{
				return (bool)base["wantResponseSinged"];
			}
			set
			{
				base["wantResponseSinged"] = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0000978D File Offset: 0x0000798D
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x0000979F File Offset: 0x0000799F
		[ConfigurationProperty("wantAssertionSigned", DefaultValue = true, IsRequired = false)]
		public bool WantAssertionSigned
		{
			get
			{
				return (bool)base["wantAssertionSigned"];
			}
			set
			{
				base["wantAssertionSigned"] = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x000097B2 File Offset: 0x000079B2
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x000097C4 File Offset: 0x000079C4
		[ConfigurationProperty("validateIdpCert", DefaultValue = true, IsRequired = false)]
		public bool ValidateIdpCert
		{
			get
			{
				return (bool)base["validateIdpCert"];
			}
			set
			{
				base["validateIdpCert"] = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x000097D7 File Offset: 0x000079D7
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x000097E9 File Offset: 0x000079E9
		[ConfigurationProperty("validateHttpHttps", DefaultValue = true, IsRequired = false)]
		public bool ValidateHttpHttps
		{
			get
			{
				return (bool)base["validateHttpHttps"];
			}
			set
			{
				base["validateHttpHttps"] = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x000097FC File Offset: 0x000079FC
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0000980E File Offset: 0x00007A0E
		[ConfigurationProperty("maxMessageAge")]
		[IntegerValidator(ExcludeRange = false, MinValue = 0, MaxValue = 86400)]
		public int MaxMessageAgeSeconds
		{
			get
			{
				return (int)base["maxMessageAge"];
			}
			set
			{
				base["maxMessageAge"] = value;
			}
		}
	}
}
