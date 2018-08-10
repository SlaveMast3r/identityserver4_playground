using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200005E RID: 94
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class ObjectType
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00007887 File Offset: 0x00005A87
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000788F File Offset: 0x00005A8F
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00007898 File Offset: 0x00005A98
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000078A0 File Offset: 0x00005AA0
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x000078A9 File Offset: 0x00005AA9
		// (set) Token: 0x060002EA RID: 746 RVA: 0x000078B1 File Offset: 0x00005AB1
		[XmlAttribute]
		public string MimeType
		{
			get
			{
				return this.mimeTypeField;
			}
			set
			{
				this.mimeTypeField = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000078BA File Offset: 0x00005ABA
		// (set) Token: 0x060002EC RID: 748 RVA: 0x000078C2 File Offset: 0x00005AC2
		[XmlAttribute(DataType = "anyURI")]
		public string Encoding
		{
			get
			{
				return this.encodingField;
			}
			set
			{
				this.encodingField = value;
			}
		}

		// Token: 0x0400011F RID: 287
		private XmlNode[] anyField;

		// Token: 0x04000120 RID: 288
		private string idField;

		// Token: 0x04000121 RID: 289
		private string mimeTypeField;

		// Token: 0x04000122 RID: 290
		private string encodingField;
	}
}
