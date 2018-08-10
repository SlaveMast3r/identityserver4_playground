using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000045 RID: 69
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class KeyInfoType
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600023D RID: 573 RVA: 0x000073AE File Offset: 0x000055AE
		// (set) Token: 0x0600023E RID: 574 RVA: 0x000073B6 File Offset: 0x000055B6
		[XmlAnyElement]
		[XmlElement("KeyName", typeof(string))]
		[XmlElement("KeyValue", typeof(KeyValueType))]
		[XmlElement("MgmtData", typeof(string))]
		[XmlElement("PGPData", typeof(PGPDataType))]
		[XmlElement("RetrievalMethod", typeof(RetrievalMethodType))]
		[XmlElement("SPKIData", typeof(SPKIDataType))]
		[XmlElement("X509Data", typeof(X509DataType))]
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600023F RID: 575 RVA: 0x000073BF File Offset: 0x000055BF
		// (set) Token: 0x06000240 RID: 576 RVA: 0x000073C7 File Offset: 0x000055C7
		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType2[] ItemsElementName
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000073D0 File Offset: 0x000055D0
		// (set) Token: 0x06000242 RID: 578 RVA: 0x000073D8 File Offset: 0x000055D8
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000073E1 File Offset: 0x000055E1
		// (set) Token: 0x06000244 RID: 580 RVA: 0x000073E9 File Offset: 0x000055E9
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

		// Token: 0x040000C2 RID: 194
		private object[] itemsField;

		// Token: 0x040000C3 RID: 195
		private ItemsChoiceType2[] itemsElementNameField;

		// Token: 0x040000C4 RID: 196
		private string[] textField;

		// Token: 0x040000C5 RID: 197
		private string idField;
	}
}
