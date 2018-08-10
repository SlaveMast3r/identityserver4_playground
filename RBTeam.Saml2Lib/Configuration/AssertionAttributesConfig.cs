using System;
using System.Configuration;

namespace RBTeam.Saml2Lib.Configuration
{
	// Token: 0x020000BA RID: 186
	public class AssertionAttributesConfig : ConfigurationElementCollection
	{
		// Token: 0x06000516 RID: 1302 RVA: 0x00009276 File Offset: 0x00007476
		protected override ConfigurationElement CreateNewElement()
		{
			return new RoleMappingRecord();
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0000927D File Offset: 0x0000747D
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((RoleMappingRecord)element).Name;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0000928A File Offset: 0x0000748A
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x0000929C File Offset: 0x0000749C
		[ConfigurationProperty("userNameAttribute", DefaultValue = "SubjectID", IsRequired = false)]
		public string UserNameAttribute
		{
			get
			{
				return (string)base["userNameAttribute"];
			}
			set
			{
				base["userNameAttribute"] = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x000092AA File Offset: 0x000074AA
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x000092BC File Offset: 0x000074BC
		[ConfigurationProperty("rolesAttribute", DefaultValue = "Role", IsRequired = false)]
		public string RolesAttribute
		{
			get
			{
				return (string)base["rolesAttribute"];
			}
			set
			{
				base["rolesAttribute"] = value;
			}
		}
	}
}
