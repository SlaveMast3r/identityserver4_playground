using System;
using System.Configuration;

namespace RBTeam.Saml2Lib.Configuration
{
	// Token: 0x020000BD RID: 189
	public class RoleMappingRecord : ConfigurationElement
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000093BA File Offset: 0x000075BA
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x000093CC File Offset: 0x000075CC
		[ConfigurationProperty("name", IsRequired = true)]
		public string Name
		{
			get
			{
				return (string)base["name"];
			}
			set
			{
				base["name"] = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000093DA File Offset: 0x000075DA
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x000093EC File Offset: 0x000075EC
		[ConfigurationProperty("prefix", IsRequired = false)]
		public string Prefix
		{
			get
			{
				return (string)base["prefix"];
			}
			set
			{
				base["prefix"] = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x000093FA File Offset: 0x000075FA
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x0000940C File Offset: 0x0000760C
		[ConfigurationProperty("regex", IsRequired = true)]
		public string Regex
		{
			get
			{
				return (string)base["regex"];
			}
			set
			{
				base["regex"] = value;
			}
		}
	}
}
