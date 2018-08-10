using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000053 RID: 83
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class SignaturePropertiesType
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000075DF File Offset: 0x000057DF
		// (set) Token: 0x0600028B RID: 651 RVA: 0x000075E7 File Offset: 0x000057E7
		[XmlElement("SignatureProperty")]
		public SignaturePropertyType[] SignatureProperty
		{
			get
			{
				return this.signaturePropertyField;
			}
			set
			{
				this.signaturePropertyField = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000075F0 File Offset: 0x000057F0
		// (set) Token: 0x0600028D RID: 653 RVA: 0x000075F8 File Offset: 0x000057F8
		[XmlAttribute(DataType = "ID")]
		public string Id
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

		// Token: 0x040000F7 RID: 247
		private SignaturePropertyType[] signaturePropertyField;

		// Token: 0x040000F8 RID: 248
		private string idField;
	}
}
