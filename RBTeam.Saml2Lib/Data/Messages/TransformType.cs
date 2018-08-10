using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200004C RID: 76
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class TransformType
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00007502 File Offset: 0x00005702
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0000750A File Offset: 0x0000570A
		[XmlAnyElement]
		[XmlElement("XPath", typeof(string))]
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00007513 File Offset: 0x00005713
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000751B File Offset: 0x0000571B
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00007524 File Offset: 0x00005724
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000752C File Offset: 0x0000572C
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

		// Token: 0x040000DA RID: 218
		private object[] itemsField;

		// Token: 0x040000DB RID: 219
		private string[] textField;

		// Token: 0x040000DC RID: 220
		private string algorithmField;
	}
}
