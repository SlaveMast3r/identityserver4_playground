using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000056 RID: 86
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class DigestMethodType
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00007689 File Offset: 0x00005889
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00007691 File Offset: 0x00005891
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000769A File Offset: 0x0000589A
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x000076A2 File Offset: 0x000058A2
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

		// Token: 0x04000101 RID: 257
		private XmlNode[] anyField;

		// Token: 0x04000102 RID: 258
		private string algorithmField;
	}
}
