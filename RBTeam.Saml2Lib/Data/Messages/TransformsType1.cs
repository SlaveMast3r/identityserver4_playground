using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200007D RID: 125
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(TypeName = "TransformsType", Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[Serializable]
	public class TransformsType1
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000080B8 File Offset: 0x000062B8
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000080C0 File Offset: 0x000062C0
		[XmlElement("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public TransformType[] Transform
		{
			get
			{
				return this.transformField;
			}
			set
			{
				this.transformField = value;
			}
		}

		// Token: 0x040001A1 RID: 417
		private TransformType[] transformField;
	}
}
