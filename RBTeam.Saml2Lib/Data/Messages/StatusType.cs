using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000095 RID: 149
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("Status", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class StatusType
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00008381 File Offset: 0x00006581
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00008389 File Offset: 0x00006589
		public StatusCodeType StatusCode
		{
			get
			{
				return this.statusCodeField;
			}
			set
			{
				this.statusCodeField = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00008392 File Offset: 0x00006592
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0000839A File Offset: 0x0000659A
		public string StatusMessage
		{
			get
			{
				return this.statusMessageField;
			}
			set
			{
				this.statusMessageField = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000083A3 File Offset: 0x000065A3
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000083AB File Offset: 0x000065AB
		public StatusDetailType StatusDetail
		{
			get
			{
				return this.statusDetailField;
			}
			set
			{
				this.statusDetailField = value;
			}
		}

		// Token: 0x040001E0 RID: 480
		private StatusCodeType statusCodeField;

		// Token: 0x040001E1 RID: 481
		private string statusMessageField;

		// Token: 0x040001E2 RID: 482
		private StatusDetailType statusDetailField;
	}
}
