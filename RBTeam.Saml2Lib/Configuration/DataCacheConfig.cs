using System;
using System.Configuration;

namespace RBTeam.Saml2Lib.Configuration
{
	// Token: 0x020000BC RID: 188
	public class DataCacheConfig : ConfigurationElement
	{
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00009355 File Offset: 0x00007555
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00009367 File Offset: 0x00007567
		[ConfigurationProperty("samlRequestLifespan", DefaultValue = "1200", IsRequired = false)]
		[IntegerValidator(ExcludeRange = false, MinValue = 0, MaxValue = 86400)]
		public int SamlRequestLifespanSeconds
		{
			get
			{
				return (int)base["samlRequestLifespan"];
			}
			set
			{
				base["samlRequestLifespan"] = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0000937A File Offset: 0x0000757A
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0000938C File Offset: 0x0000758C
		[ConfigurationProperty("cookieName", DefaultValue = "Saml2ModuleAutz", IsRequired = false)]
		public string CookieName
		{
			get
			{
				return (string)base["cookieName"];
			}
			set
			{
				base["cookieName"] = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0000939A File Offset: 0x0000759A
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x000093AC File Offset: 0x000075AC
		[ConfigurationProperty("cookiePath", DefaultValue = null, IsRequired = false)]
		public string CookiePath
		{
			get
			{
				return (string)base["cookiePath"];
			}
			set
			{
				base["cookiePath"] = value;
			}
		}
	}
}
