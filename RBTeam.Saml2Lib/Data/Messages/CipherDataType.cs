using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200007B RID: 123
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[XmlRoot("CipherData", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
	[Serializable]
	public class CipherDataType
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00008085 File Offset: 0x00006285
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000808D File Offset: 0x0000628D
		[XmlElement("CipherReference", typeof(CipherReferenceType))]
		[XmlElement("CipherValue", typeof(byte[]), DataType = "base64Binary")]
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

		// Token: 0x0400019E RID: 414
		private object itemField;
	}
}
