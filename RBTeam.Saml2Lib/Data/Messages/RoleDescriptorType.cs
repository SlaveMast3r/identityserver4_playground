using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200006B RID: 107
	[XmlInclude(typeof(AttributeAuthorityDescriptorType))]
	[XmlInclude(typeof(PDPDescriptorType))]
	[XmlInclude(typeof(AuthnAuthorityDescriptorType))]
	[XmlInclude(typeof(SSODescriptorType))]
	[XmlInclude(typeof(SPSSODescriptorType))]
	[XmlInclude(typeof(IDPSSODescriptorType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("RoleDescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public abstract class RoleDescriptorType
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00007B6A File Offset: 0x00005D6A
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00007B72 File Offset: 0x00005D72
		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureType Signature
		{
			get
			{
				return this.signatureField;
			}
			set
			{
				this.signatureField = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00007B7B File Offset: 0x00005D7B
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00007B83 File Offset: 0x00005D83
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00007B8C File Offset: 0x00005D8C
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00007B94 File Offset: 0x00005D94
		[XmlElement("KeyDescriptor")]
		public KeyDescriptorType[] KeyDescriptor
		{
			get
			{
				return this.keyDescriptorField;
			}
			set
			{
				this.keyDescriptorField = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00007B9D File Offset: 0x00005D9D
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00007BA5 File Offset: 0x00005DA5
		public OrganizationType Organization
		{
			get
			{
				return this.organizationField;
			}
			set
			{
				this.organizationField = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00007BAE File Offset: 0x00005DAE
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00007BB6 File Offset: 0x00005DB6
		[XmlElement("ContactPerson")]
		public ContactType[] ContactPerson
		{
			get
			{
				return this.contactPersonField;
			}
			set
			{
				this.contactPersonField = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00007BBF File Offset: 0x00005DBF
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00007BC7 File Offset: 0x00005DC7
		[XmlAttribute(DataType = "ID")]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00007BD0 File Offset: 0x00005DD0
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[XmlAttribute]
		public DateTime validUntil
		{
			get
			{
				return this.validUntilField;
			}
			set
			{
				this.validUntilField = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00007BE1 File Offset: 0x00005DE1
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00007BE9 File Offset: 0x00005DE9
		[XmlIgnore]
		public bool validUntilSpecified
		{
			get
			{
				return this.validUntilFieldSpecified;
			}
			set
			{
				this.validUntilFieldSpecified = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00007BF2 File Offset: 0x00005DF2
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00007BFA File Offset: 0x00005DFA
		[XmlAttribute(DataType = "duration")]
		public string cacheDuration
		{
			get
			{
				return this.cacheDurationField;
			}
			set
			{
				this.cacheDurationField = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00007C03 File Offset: 0x00005E03
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00007C0B File Offset: 0x00005E0B
		[XmlAttribute(DataType = "anyURI")]
		public string[] protocolSupportEnumeration
		{
			get
			{
				return this.protocolSupportEnumerationField;
			}
			set
			{
				this.protocolSupportEnumerationField = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00007C14 File Offset: 0x00005E14
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00007C1C File Offset: 0x00005E1C
		[XmlAttribute(DataType = "anyURI")]
		public string errorURL
		{
			get
			{
				return this.errorURLField;
			}
			set
			{
				this.errorURLField = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00007C25 File Offset: 0x00005E25
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00007C2D File Offset: 0x00005E2D
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

		// Token: 0x04000153 RID: 339
		private SignatureType signatureField;

		// Token: 0x04000154 RID: 340
		private ExtensionsType1 extensionsField;

		// Token: 0x04000155 RID: 341
		private KeyDescriptorType[] keyDescriptorField;

		// Token: 0x04000156 RID: 342
		private OrganizationType organizationField;

		// Token: 0x04000157 RID: 343
		private ContactType[] contactPersonField;

		// Token: 0x04000158 RID: 344
		private string idField;

		// Token: 0x04000159 RID: 345
		private DateTime validUntilField;

		// Token: 0x0400015A RID: 346
		private bool validUntilFieldSpecified;

		// Token: 0x0400015B RID: 347
		private string cacheDurationField;

		// Token: 0x0400015C RID: 348
		private string[] protocolSupportEnumerationField;

		// Token: 0x0400015D RID: 349
		private string errorURLField;

		// Token: 0x0400015E RID: 350
		private XmlAttribute[] anyAttrField;
	}
}
