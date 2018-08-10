using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000AA RID: 170
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class TransformsType
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x000085FE File Offset: 0x000067FE
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00008606 File Offset: 0x00006806
		[XmlElement("Transform")]
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

		// Token: 0x0400020D RID: 525
		private TransformType[] transformField;
	}
}
