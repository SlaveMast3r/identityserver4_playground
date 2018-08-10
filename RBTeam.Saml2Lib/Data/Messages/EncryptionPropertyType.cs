using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200007F RID: 127
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[XmlRoot("EncryptionProperty", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
	[Serializable]
	public class EncryptionPropertyType
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000080EB File Offset: 0x000062EB
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x000080F3 File Offset: 0x000062F3
		[XmlAnyElement]
		public XmlElement[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000080FC File Offset: 0x000062FC
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00008104 File Offset: 0x00006304
		[XmlText]
		public string[] Text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000810D File Offset: 0x0000630D
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00008115 File Offset: 0x00006315
		[XmlAttribute(DataType = "anyURI")]
		public string Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000811E File Offset: 0x0000631E
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00008126 File Offset: 0x00006326
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

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000812F File Offset: 0x0000632F
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00008137 File Offset: 0x00006337
		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.anyAttrField;
			}
			set
			{
				this.anyAttrField = value;
			}
		}

		// Token: 0x040001A4 RID: 420
		private XmlElement[] itemsField;

		// Token: 0x040001A5 RID: 421
		private string[] textField;

		// Token: 0x040001A6 RID: 422
		private string targetField;

		// Token: 0x040001A7 RID: 423
		private string idField;

		// Token: 0x040001A8 RID: 424
		private XmlAttribute[] anyAttrField;
	}
}
