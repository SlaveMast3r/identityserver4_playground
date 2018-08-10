using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200006C RID: 108
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("AttributeAuthorityDescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class AttributeAuthorityDescriptorType : RoleDescriptorType
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00007C36 File Offset: 0x00005E36
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00007C3E File Offset: 0x00005E3E
		[XmlElement("AttributeService")]
		public EndpointType[] AttributeService
		{
			get
			{
				return this.attributeServiceField;
			}
			set
			{
				this.attributeServiceField = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00007C47 File Offset: 0x00005E47
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00007C4F File Offset: 0x00005E4F
		[XmlElement("AssertionIDRequestService")]
		public EndpointType[] AssertionIDRequestService
		{
			get
			{
				return this.assertionIDRequestServiceField;
			}
			set
			{
				this.assertionIDRequestServiceField = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00007C58 File Offset: 0x00005E58
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00007C60 File Offset: 0x00005E60
		[XmlElement("NameIDFormat", DataType = "anyURI")]
		public string[] NameIDFormat
		{
			get
			{
				return this.nameIDFormatField;
			}
			set
			{
				this.nameIDFormatField = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00007C69 File Offset: 0x00005E69
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00007C71 File Offset: 0x00005E71
		[XmlElement("AttributeProfile", DataType = "anyURI")]
		public string[] AttributeProfile
		{
			get
			{
				return this.attributeProfileField;
			}
			set
			{
				this.attributeProfileField = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00007C7A File Offset: 0x00005E7A
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00007C82 File Offset: 0x00005E82
		[XmlElement("Attribute", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public AttributeType[] Attribute
		{
			get
			{
				return this.attributeField;
			}
			set
			{
				this.attributeField = value;
			}
		}

		// Token: 0x0400015F RID: 351
		private EndpointType[] attributeServiceField;

		// Token: 0x04000160 RID: 352
		private EndpointType[] assertionIDRequestServiceField;

		// Token: 0x04000161 RID: 353
		private string[] nameIDFormatField;

		// Token: 0x04000162 RID: 354
		private string[] attributeProfileField;

		// Token: 0x04000163 RID: 355
		private AttributeType[] attributeField;
	}
}
