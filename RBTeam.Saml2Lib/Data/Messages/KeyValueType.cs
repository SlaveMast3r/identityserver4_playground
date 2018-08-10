using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000046 RID: 70
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class KeyValueType
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000073F2 File Offset: 0x000055F2
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000073FA File Offset: 0x000055FA
		[XmlAnyElement]
		[XmlElement("DSAKeyValue", typeof(DSAKeyValueType))]
		[XmlElement("RSAKeyValue", typeof(RSAKeyValueType))]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00007403 File Offset: 0x00005603
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000740B File Offset: 0x0000560B
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

		// Token: 0x040000C6 RID: 198
		private object itemField;

		// Token: 0x040000C7 RID: 199
		private string[] textField;
	}
}
