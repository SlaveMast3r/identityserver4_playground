using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200005C RID: 92
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class SignatureMethodType
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00007832 File Offset: 0x00005A32
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0000783A File Offset: 0x00005A3A
		[XmlElement(DataType = "integer")]
		public string HMACOutputLength
		{
			get
			{
				return this.hMACOutputLengthField;
			}
			set
			{
				this.hMACOutputLengthField = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00007843 File Offset: 0x00005A43
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000784B File Offset: 0x00005A4B
		[XmlText]
		[XmlAnyElement]
		public XmlNode[] Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00007854 File Offset: 0x00005A54
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000785C File Offset: 0x00005A5C
		[XmlAttribute(DataType = "anyURI")]
		public string Algorithm
		{
			get
			{
				return this.algorithmField;
			}
			set
			{
				this.algorithmField = value;
			}
		}

		// Token: 0x0400011A RID: 282
		private string hMACOutputLengthField;

		// Token: 0x0400011B RID: 283
		private XmlNode[] anyField;

		// Token: 0x0400011C RID: 284
		private string algorithmField;
	}
}
