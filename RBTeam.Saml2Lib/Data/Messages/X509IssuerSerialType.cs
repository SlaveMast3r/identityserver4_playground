using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200004F RID: 79
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[Serializable]
	public class X509IssuerSerialType
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00007579 File Offset: 0x00005779
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00007581 File Offset: 0x00005781
		public string X509IssuerName
		{
			get
			{
				return this.x509IssuerNameField;
			}
			set
			{
				this.x509IssuerNameField = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000758A File Offset: 0x0000578A
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00007592 File Offset: 0x00005792
		[XmlElement(DataType = "integer")]
		public string X509SerialNumber
		{
			get
			{
				return this.x509SerialNumberField;
			}
			set
			{
				this.x509SerialNumberField = value;
			}
		}

		// Token: 0x040000E1 RID: 225
		private string x509IssuerNameField;

		// Token: 0x040000E2 RID: 226
		private string x509SerialNumberField;
	}
}
