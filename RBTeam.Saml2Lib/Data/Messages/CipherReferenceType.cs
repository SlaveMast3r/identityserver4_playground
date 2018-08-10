using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200007C RID: 124
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[XmlRoot("CipherReference", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
	[Serializable]
	public class CipherReferenceType
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00008096 File Offset: 0x00006296
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0000809E File Offset: 0x0000629E
		[XmlElement("Transforms")]
		public TransformsType1 Item
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

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000080A7 File Offset: 0x000062A7
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000080AF File Offset: 0x000062AF
		[XmlAttribute(DataType = "anyURI")]
		public string URI
		{
			get
			{
				return this.uRIField;
			}
			set
			{
				this.uRIField = value;
			}
		}

		// Token: 0x0400019F RID: 415
		private TransformsType1 itemField;

		// Token: 0x040001A0 RID: 416
		private string uRIField;
	}
}
