using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000073 RID: 115
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("IDPSSODescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class IDPSSODescriptorType : SSODescriptorType
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00007E3B File Offset: 0x0000603B
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00007E43 File Offset: 0x00006043
		[XmlElement("SingleSignOnService")]
		public EndpointType[] SingleSignOnService
		{
			get
			{
				return this.singleSignOnServiceField;
			}
			set
			{
				this.singleSignOnServiceField = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00007E4C File Offset: 0x0000604C
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00007E54 File Offset: 0x00006054
		[XmlElement("NameIDMappingService")]
		public EndpointType[] NameIDMappingService
		{
			get
			{
				return this.nameIDMappingServiceField;
			}
			set
			{
				this.nameIDMappingServiceField = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00007E5D File Offset: 0x0000605D
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00007E65 File Offset: 0x00006065
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00007E6E File Offset: 0x0000606E
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00007E76 File Offset: 0x00006076
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00007E7F File Offset: 0x0000607F
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00007E87 File Offset: 0x00006087
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00007E90 File Offset: 0x00006090
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00007E98 File Offset: 0x00006098
		[XmlAttribute]
		public bool WantAuthnRequestsSigned
		{
			get
			{
				return this.wantAuthnRequestsSignedField;
			}
			set
			{
				this.wantAuthnRequestsSignedField = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00007EA1 File Offset: 0x000060A1
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00007EA9 File Offset: 0x000060A9
		[XmlIgnore]
		public bool WantAuthnRequestsSignedSpecified
		{
			get
			{
				return this.wantAuthnRequestsSignedFieldSpecified;
			}
			set
			{
				this.wantAuthnRequestsSignedFieldSpecified = value;
			}
		}

		// Token: 0x0400017C RID: 380
		private EndpointType[] singleSignOnServiceField;

		// Token: 0x0400017D RID: 381
		private EndpointType[] nameIDMappingServiceField;

		// Token: 0x0400017E RID: 382
		private EndpointType[] assertionIDRequestServiceField;

		// Token: 0x0400017F RID: 383
		private string[] attributeProfileField;

		// Token: 0x04000180 RID: 384
		private AttributeType[] attributeField;

		// Token: 0x04000181 RID: 385
		private bool wantAuthnRequestsSignedField;

		// Token: 0x04000182 RID: 386
		private bool wantAuthnRequestsSignedFieldSpecified;
	}
}
