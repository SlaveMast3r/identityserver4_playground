using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200006F RID: 111
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("PDPDescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class PDPDescriptorType : RoleDescriptorType
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00007D23 File Offset: 0x00005F23
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00007D2B File Offset: 0x00005F2B
		[XmlElement("AuthzService")]
		public EndpointType[] AuthzService
		{
			get
			{
				return this.authzServiceField;
			}
			set
			{
				this.authzServiceField = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00007D34 File Offset: 0x00005F34
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00007D3C File Offset: 0x00005F3C
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

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00007D45 File Offset: 0x00005F45
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00007D4D File Offset: 0x00005F4D
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

		// Token: 0x0400016C RID: 364
		private EndpointType[] authzServiceField;

		// Token: 0x0400016D RID: 365
		private EndpointType[] assertionIDRequestServiceField;

		// Token: 0x0400016E RID: 366
		private string[] nameIDFormatField;
	}
}
