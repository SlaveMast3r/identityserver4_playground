using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000049 RID: 73
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class PGPDataType
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600025F RID: 607 RVA: 0x000074AD File Offset: 0x000056AD
		// (set) Token: 0x06000260 RID: 608 RVA: 0x000074B5 File Offset: 0x000056B5
		[XmlAnyElement]
		[XmlElement("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
		[XmlElement("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
		[XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000074BE File Offset: 0x000056BE
		// (set) Token: 0x06000262 RID: 610 RVA: 0x000074C6 File Offset: 0x000056C6
		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType1[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		// Token: 0x040000D1 RID: 209
		private object[] itemsField;

		// Token: 0x040000D2 RID: 210
		private ItemsChoiceType1[] itemsElementNameField;
	}
}
