using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000067 RID: 103
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("ContactPerson", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class ContactType
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00007A6B File Offset: 0x00005C6B
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00007A73 File Offset: 0x00005C73
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00007A7C File Offset: 0x00005C7C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00007A84 File Offset: 0x00005C84
		public string Company
		{
			get
			{
				return this.companyField;
			}
			set
			{
				this.companyField = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00007A8D File Offset: 0x00005C8D
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00007A95 File Offset: 0x00005C95
		public string GivenName
		{
			get
			{
				return this.givenNameField;
			}
			set
			{
				this.givenNameField = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00007A9E File Offset: 0x00005C9E
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00007AA6 File Offset: 0x00005CA6
		public string SurName
		{
			get
			{
				return this.surNameField;
			}
			set
			{
				this.surNameField = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00007AAF File Offset: 0x00005CAF
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00007AB7 File Offset: 0x00005CB7
		[XmlElement("EmailAddress", DataType = "anyURI")]
		public string[] EmailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00007AC0 File Offset: 0x00005CC0
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00007AC8 File Offset: 0x00005CC8
		[XmlElement("TelephoneNumber")]
		public string[] TelephoneNumber
		{
			get
			{
				return this.telephoneNumberField;
			}
			set
			{
				this.telephoneNumberField = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00007AD1 File Offset: 0x00005CD1
		// (set) Token: 0x06000332 RID: 818 RVA: 0x00007AD9 File Offset: 0x00005CD9
		[XmlAttribute]
		public ContactTypeType contactType
		{
			get
			{
				return this.contactTypeField;
			}
			set
			{
				this.contactTypeField = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00007AE2 File Offset: 0x00005CE2
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00007AEA File Offset: 0x00005CEA
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

		// Token: 0x0400013E RID: 318
		private ExtensionsType1 extensionsField;

		// Token: 0x0400013F RID: 319
		private string companyField;

		// Token: 0x04000140 RID: 320
		private string givenNameField;

		// Token: 0x04000141 RID: 321
		private string surNameField;

		// Token: 0x04000142 RID: 322
		private string[] emailAddressField;

		// Token: 0x04000143 RID: 323
		private string[] telephoneNumberField;

		// Token: 0x04000144 RID: 324
		private ContactTypeType contactTypeField;

		// Token: 0x04000145 RID: 325
		private XmlAttribute[] anyAttrField;
	}
}
