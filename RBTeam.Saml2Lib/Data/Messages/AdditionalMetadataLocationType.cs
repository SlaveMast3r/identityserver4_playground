using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000057 RID: 87
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("AdditionalMetadataLocation", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class AdditionalMetadataLocationType
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x000076AB File Offset: 0x000058AB
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x000076B3 File Offset: 0x000058B3
		[XmlAttribute(DataType = "anyURI")]
		public string @namespace
		{
			get
			{
				return this.namespaceField;
			}
			set
			{
				this.namespaceField = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x000076BC File Offset: 0x000058BC
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x000076C4 File Offset: 0x000058C4
		[XmlText(DataType = "anyURI")]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x04000103 RID: 259
		private string namespaceField;

		// Token: 0x04000104 RID: 260
		private string valueField;
	}
}
