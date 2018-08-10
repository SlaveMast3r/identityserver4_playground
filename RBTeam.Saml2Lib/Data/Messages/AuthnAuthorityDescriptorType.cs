using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000070 RID: 112
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("AuthnAuthorityDescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class AuthnAuthorityDescriptorType : RoleDescriptorType
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00007D56 File Offset: 0x00005F56
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00007D5E File Offset: 0x00005F5E
		[XmlElement("AuthnQueryService")]
		public EndpointType[] AuthnQueryService
		{
			get
			{
				return this.authnQueryServiceField;
			}
			set
			{
				this.authnQueryServiceField = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00007D67 File Offset: 0x00005F67
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00007D6F File Offset: 0x00005F6F
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00007D78 File Offset: 0x00005F78
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00007D80 File Offset: 0x00005F80
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

		// Token: 0x0400016F RID: 367
		private EndpointType[] authnQueryServiceField;

		// Token: 0x04000170 RID: 368
		private EndpointType[] assertionIDRequestServiceField;

		// Token: 0x04000171 RID: 369
		private string[] nameIDFormatField;
	}
}
