using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000055 RID: 85
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class ReferenceType
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00007623 File Offset: 0x00005823
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000762B File Offset: 0x0000582B
		[XmlArrayItem("Transform", IsNullable = false)]
		public TransformType[] Transforms
		{
			get
			{
				return this.transformsField;
			}
			set
			{
				this.transformsField = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00007634 File Offset: 0x00005834
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000763C File Offset: 0x0000583C
		public DigestMethodType DigestMethod
		{
			get
			{
				return this.digestMethodField;
			}
			set
			{
				this.digestMethodField = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00007645 File Offset: 0x00005845
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0000764D File Offset: 0x0000584D
		[XmlElement(DataType = "base64Binary")]
		public byte[] DigestValue
		{
			get
			{
				return this.digestValueField;
			}
			set
			{
				this.digestValueField = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00007656 File Offset: 0x00005856
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000765E File Offset: 0x0000585E
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00007667 File Offset: 0x00005867
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000766F File Offset: 0x0000586F
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00007678 File Offset: 0x00005878
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00007680 File Offset: 0x00005880
		[XmlAttribute(DataType = "anyURI")]
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x040000FB RID: 251
		private TransformType[] transformsField;

		// Token: 0x040000FC RID: 252
		private DigestMethodType digestMethodField;

		// Token: 0x040000FD RID: 253
		private byte[] digestValueField;

		// Token: 0x040000FE RID: 254
		private string idField;

		// Token: 0x040000FF RID: 255
		private string uRIField;

		// Token: 0x04000100 RID: 256
		private string typeField;
	}
}
