using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200005D RID: 93
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class SignatureValueType
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00007865 File Offset: 0x00005A65
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0000786D File Offset: 0x00005A6D
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00007876 File Offset: 0x00005A76
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000787E File Offset: 0x00005A7E
		[XmlText(DataType = "base64Binary")]
		public byte[] Value
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

		// Token: 0x0400011D RID: 285
		private string idField;

		// Token: 0x0400011E RID: 286
		private byte[] valueField;
	}
}
