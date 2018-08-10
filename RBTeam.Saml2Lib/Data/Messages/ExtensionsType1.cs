using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200005F RID: 95
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(TypeName = "ExtensionsType", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("Extensions", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class ExtensionsType1
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000078CB File Offset: 0x00005ACB
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000078D3 File Offset: 0x00005AD3
		[XmlAnyElement]
		public XmlElement[] Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
			}
		}

		// Token: 0x04000123 RID: 291
		private XmlElement[] anyField;
	}
}
