using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000052 RID: 82
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class SignaturePropertyType
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000759B File Offset: 0x0000579B
		// (set) Token: 0x06000282 RID: 642 RVA: 0x000075A3 File Offset: 0x000057A3
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000283 RID: 643 RVA: 0x000075AC File Offset: 0x000057AC
		// (set) Token: 0x06000284 RID: 644 RVA: 0x000075B4 File Offset: 0x000057B4
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000075BD File Offset: 0x000057BD
		// (set) Token: 0x06000286 RID: 646 RVA: 0x000075C5 File Offset: 0x000057C5
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000287 RID: 647 RVA: 0x000075CE File Offset: 0x000057CE
		// (set) Token: 0x06000288 RID: 648 RVA: 0x000075D6 File Offset: 0x000057D6
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

		// Token: 0x040000F3 RID: 243
		private XmlElement[] itemsField;

		// Token: 0x040000F4 RID: 244
		private string[] textField;

		// Token: 0x040000F5 RID: 245
		private string targetField;

		// Token: 0x040000F6 RID: 246
		private string idField;
	}
}
