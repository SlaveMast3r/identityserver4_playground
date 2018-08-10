using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200004B RID: 75
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class RetrievalMethodType
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000074CF File Offset: 0x000056CF
		// (set) Token: 0x06000265 RID: 613 RVA: 0x000074D7 File Offset: 0x000056D7
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000074E0 File Offset: 0x000056E0
		// (set) Token: 0x06000267 RID: 615 RVA: 0x000074E8 File Offset: 0x000056E8
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000268 RID: 616 RVA: 0x000074F1 File Offset: 0x000056F1
		// (set) Token: 0x06000269 RID: 617 RVA: 0x000074F9 File Offset: 0x000056F9
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

		// Token: 0x040000D7 RID: 215
		private TransformType[] transformsField;

		// Token: 0x040000D8 RID: 216
		private string uRIField;

		// Token: 0x040000D9 RID: 217
		private string typeField;
	}
}
