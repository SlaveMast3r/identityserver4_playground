using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace RBTeam.Saml2Lib.Configuration
{
	// Token: 0x020000BB RID: 187
	public class CertificateStoreConfig : ConfigurationElement
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x000092D2 File Offset: 0x000074D2
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x000092E4 File Offset: 0x000074E4
		[ConfigurationProperty("storeLocation", DefaultValue = "My", IsRequired = false)]
		public string StoreLocation
		{
			get
			{
				return (string)base["storeLocation"];
			}
			set
			{
				base["storeLocation"] = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000092F2 File Offset: 0x000074F2
		public StoreLocation StoreLocationEnum
		{
			get
			{
				return (StoreLocation)Enum.Parse(typeof(StoreLocation), this.StoreLocation);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000930E File Offset: 0x0000750E
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00009320 File Offset: 0x00007520
		[ConfigurationProperty("storeName", DefaultValue = "LocalMachine", IsRequired = false)]
		public string StoreName
		{
			get
			{
				return (string)base["storeName"];
			}
			set
			{
				base["storeName"] = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000932E File Offset: 0x0000752E
		public StoreName StoreNameEnum
		{
			get
			{
				return (StoreName)Enum.Parse(typeof(StoreName), this.StoreName);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0000934A File Offset: 0x0000754A
		public X509FindType FindTypeEnum
		{
			get
			{
				return X509FindType.FindByThumbprint;
			}
		}
	}
}
