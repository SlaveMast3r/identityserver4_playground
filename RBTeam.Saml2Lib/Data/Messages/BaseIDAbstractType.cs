using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000077 RID: 119
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("BaseID", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public abstract class BaseIDAbstractType
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00007FB1 File Offset: 0x000061B1
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00007FB9 File Offset: 0x000061B9
		[XmlAttribute]
		public string NameQualifier
		{
			get
			{
				return this.nameQualifierField;
			}
			set
			{
				this.nameQualifierField = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00007FC2 File Offset: 0x000061C2
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00007FCA File Offset: 0x000061CA
		[XmlAttribute]
		public string SPNameQualifier
		{
			get
			{
				return this.sPNameQualifierField;
			}
			set
			{
				this.sPNameQualifierField = value;
			}
		}

		// Token: 0x04000192 RID: 402
		private string nameQualifierField;

		// Token: 0x04000193 RID: 403
		private string sPNameQualifierField;
	}
}
