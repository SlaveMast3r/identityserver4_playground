using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200003A RID: 58
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("EntityDescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class EntityDescriptorType
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00006E20 File Offset: 0x00005020
		public SSODescriptorType Entity
		{
			get
			{
				if (this.Items == null || !this.Items.Any<object>())
				{
					return null;
				}
				if (this.Items.Length != 1)
				{
					throw new Saml2ModuleException("None or multiple entity roles in metadata for: " + this.entityID);
				}
				return this.Items[0] as SSODescriptorType;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00006E72 File Offset: 0x00005072
		public bool IsIDP
		{
			get
			{
				return this.Entity is IDPSSODescriptorType;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00006E82 File Offset: 0x00005082
		public bool IsSP
		{
			get
			{
				return this.Entity is SPSSODescriptorType;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00006E92 File Offset: 0x00005092
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00006E9A File Offset: 0x0000509A
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00006EA3 File Offset: 0x000050A3
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00006EAB File Offset: 0x000050AB
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00006EB4 File Offset: 0x000050B4
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00006EBC File Offset: 0x000050BC
		[XmlElement("AffiliationDescriptor", typeof(AffiliationDescriptorType))]
		[XmlElement("AttributeAuthorityDescriptor", typeof(AttributeAuthorityDescriptorType))]
		[XmlElement("AuthnAuthorityDescriptor", typeof(AuthnAuthorityDescriptorType))]
		[XmlElement("IDPSSODescriptor", typeof(IDPSSODescriptorType))]
		[XmlElement("PDPDescriptor", typeof(PDPDescriptorType))]
		[XmlElement("RoleDescriptor", typeof(RoleDescriptorType))]
		[XmlElement("SPSSODescriptor", typeof(SPSSODescriptorType))]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00006EC5 File Offset: 0x000050C5
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00006ECD File Offset: 0x000050CD
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00006ED6 File Offset: 0x000050D6
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00006EDE File Offset: 0x000050DE
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00006EE7 File Offset: 0x000050E7
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00006EEF File Offset: 0x000050EF
		[XmlElement("AdditionalMetadataLocation")]
		public AdditionalMetadataLocationType[] AdditionalMetadataLocation
		{
			get
			{
				return this.additionalMetadataLocationField;
			}
			set
			{
				this.additionalMetadataLocationField = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00006EF8 File Offset: 0x000050F8
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00006F00 File Offset: 0x00005100
		[XmlAttribute(DataType = "anyURI")]
		public string entityID
		{
			get
			{
				return this.entityIDField;
			}
			set
			{
				this.entityIDField = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00006F09 File Offset: 0x00005109
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00006F11 File Offset: 0x00005111
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00006F1A File Offset: 0x0000511A
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00006F22 File Offset: 0x00005122
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00006F2B File Offset: 0x0000512B
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00006F33 File Offset: 0x00005133
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00006F3C File Offset: 0x0000513C
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00006F44 File Offset: 0x00005144
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00006F4D File Offset: 0x0000514D
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00006F55 File Offset: 0x00005155
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

		// Token: 0x04000090 RID: 144
		private SignatureType signatureField;

		// Token: 0x04000091 RID: 145
		private ExtensionsType1 extensionsField;

		// Token: 0x04000092 RID: 146
		private object[] itemsField;

		// Token: 0x04000093 RID: 147
		private OrganizationType organizationField;

		// Token: 0x04000094 RID: 148
		private ContactType[] contactPersonField;

		// Token: 0x04000095 RID: 149
		private AdditionalMetadataLocationType[] additionalMetadataLocationField;

		// Token: 0x04000096 RID: 150
		private string entityIDField;

		// Token: 0x04000097 RID: 151
		private DateTime validUntilField;

		// Token: 0x04000098 RID: 152
		private bool validUntilFieldSpecified;

		// Token: 0x04000099 RID: 153
		private string cacheDurationField;

		// Token: 0x0400009A RID: 154
		private string idField;

		// Token: 0x0400009B RID: 155
		private XmlAttribute[] anyAttrField;
	}
}
