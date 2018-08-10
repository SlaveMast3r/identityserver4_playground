using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000072 RID: 114
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("SPSSODescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class SPSSODescriptorType : SSODescriptorType
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00007DCD File Offset: 0x00005FCD
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00007DD5 File Offset: 0x00005FD5
		[XmlElement("AssertionConsumerService")]
		public IndexedEndpointType[] AssertionConsumerService
		{
			get
			{
				return this.assertionConsumerServiceField;
			}
			set
			{
				this.assertionConsumerServiceField = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00007DDE File Offset: 0x00005FDE
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00007DE6 File Offset: 0x00005FE6
		[XmlElement("AttributeConsumingService")]
		public AttributeConsumingServiceType[] AttributeConsumingService
		{
			get
			{
				return this.attributeConsumingServiceField;
			}
			set
			{
				this.attributeConsumingServiceField = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00007DEF File Offset: 0x00005FEF
		// (set) Token: 0x06000398 RID: 920 RVA: 0x00007DF7 File Offset: 0x00005FF7
		[XmlAttribute]
		public bool AuthnRequestsSigned
		{
			get
			{
				return this.authnRequestsSignedField;
			}
			set
			{
				this.authnRequestsSignedField = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00007E00 File Offset: 0x00006000
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00007E08 File Offset: 0x00006008
		[XmlIgnore]
		public bool AuthnRequestsSignedSpecified
		{
			get
			{
				return this.authnRequestsSignedFieldSpecified;
			}
			set
			{
				this.authnRequestsSignedFieldSpecified = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00007E11 File Offset: 0x00006011
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00007E19 File Offset: 0x00006019
		[XmlAttribute]
		public bool WantAssertionsSigned
		{
			get
			{
				return this.wantAssertionsSignedField;
			}
			set
			{
				this.wantAssertionsSignedField = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00007E22 File Offset: 0x00006022
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00007E2A File Offset: 0x0000602A
		[XmlIgnore]
		public bool WantAssertionsSignedSpecified
		{
			get
			{
				return this.wantAssertionsSignedFieldSpecified;
			}
			set
			{
				this.wantAssertionsSignedFieldSpecified = value;
			}
		}

		// Token: 0x04000176 RID: 374
		private IndexedEndpointType[] assertionConsumerServiceField;

		// Token: 0x04000177 RID: 375
		private AttributeConsumingServiceType[] attributeConsumingServiceField;

		// Token: 0x04000178 RID: 376
		private bool authnRequestsSignedField;

		// Token: 0x04000179 RID: 377
		private bool authnRequestsSignedFieldSpecified;

		// Token: 0x0400017A RID: 378
		private bool wantAssertionsSignedField;

		// Token: 0x0400017B RID: 379
		private bool wantAssertionsSignedFieldSpecified;
	}
}
