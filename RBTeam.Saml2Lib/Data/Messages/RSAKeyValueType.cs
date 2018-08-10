using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000048 RID: 72
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class RSAKeyValueType
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000748B File Offset: 0x0000568B
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00007493 File Offset: 0x00005693
		[XmlElement(DataType = "base64Binary")]
		public byte[] Modulus
		{
			get
			{
				return this.modulusField;
			}
			set
			{
				this.modulusField = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000749C File Offset: 0x0000569C
		// (set) Token: 0x0600025D RID: 605 RVA: 0x000074A4 File Offset: 0x000056A4
		[XmlElement(DataType = "base64Binary")]
		public byte[] Exponent
		{
			get
			{
				return this.exponentField;
			}
			set
			{
				this.exponentField = value;
			}
		}

		// Token: 0x040000CF RID: 207
		private byte[] modulusField;

		// Token: 0x040000D0 RID: 208
		private byte[] exponentField;
	}
}
