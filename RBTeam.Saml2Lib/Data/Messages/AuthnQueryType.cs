using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200009A RID: 154
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("AuthnQuery", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class AuthnQueryType : SubjectQueryAbstractType
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00008409 File Offset: 0x00006609
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00008411 File Offset: 0x00006611
		public RequestedAuthnContextType RequestedAuthnContext
		{
			get
			{
				return this.requestedAuthnContextField;
			}
			set
			{
				this.requestedAuthnContextField = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000841A File Offset: 0x0000661A
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00008422 File Offset: 0x00006622
		[XmlAttribute]
		public string SessionIndex
		{
			get
			{
				return this.sessionIndexField;
			}
			set
			{
				this.sessionIndexField = value;
			}
		}

		// Token: 0x040001E8 RID: 488
		private RequestedAuthnContextType requestedAuthnContextField;

		// Token: 0x040001E9 RID: 489
		private string sessionIndexField;
	}
}
