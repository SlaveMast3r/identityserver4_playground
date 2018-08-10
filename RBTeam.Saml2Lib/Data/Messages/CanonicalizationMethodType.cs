using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200005B RID: 91
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class CanonicalizationMethodType
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00007810 File Offset: 0x00005A10
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00007818 File Offset: 0x00005A18
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00007821 File Offset: 0x00005A21
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00007829 File Offset: 0x00005A29
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

		// Token: 0x04000118 RID: 280
		private XmlNode[] anyField;

		// Token: 0x04000119 RID: 281
		private string algorithmField;
	}
}
