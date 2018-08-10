using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200006A RID: 106
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("Organization", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class OrganizationType
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00007B15 File Offset: 0x00005D15
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00007B1D File Offset: 0x00005D1D
		public ExtensionsType1 Extensions
		{
			get
			{
				return this.extensionsField;
			}
			set
			{
				this.extensionsField = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00007B26 File Offset: 0x00005D26
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00007B2E File Offset: 0x00005D2E
		[XmlElement("OrganizationName")]
		public localizedNameType[] OrganizationName
		{
			get
			{
				return this.organizationNameField;
			}
			set
			{
				this.organizationNameField = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00007B37 File Offset: 0x00005D37
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00007B3F File Offset: 0x00005D3F
		[XmlElement("OrganizationDisplayName")]
		public localizedNameType[] OrganizationDisplayName
		{
			get
			{
				return this.organizationDisplayNameField;
			}
			set
			{
				this.organizationDisplayNameField = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00007B48 File Offset: 0x00005D48
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00007B50 File Offset: 0x00005D50
		[XmlElement("OrganizationURL")]
		public localizedURIType[] OrganizationURL
		{
			get
			{
				return this.organizationURLField;
			}
			set
			{
				this.organizationURLField = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00007B59 File Offset: 0x00005D59
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00007B61 File Offset: 0x00005D61
		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.anyAttrField;
			}
			set
			{
				this.anyAttrField = value;
			}
		}

		// Token: 0x0400014E RID: 334
		private ExtensionsType1 extensionsField;

		// Token: 0x0400014F RID: 335
		private localizedNameType[] organizationNameField;

		// Token: 0x04000150 RID: 336
		private localizedNameType[] organizationDisplayNameField;

		// Token: 0x04000151 RID: 337
		private localizedURIType[] organizationURLField;

		// Token: 0x04000152 RID: 338
		private XmlAttribute[] anyAttrField;
	}
}
