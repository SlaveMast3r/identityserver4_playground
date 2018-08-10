using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000061 RID: 97
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[XmlRoot("EncryptionMethod", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class EncryptionMethodType
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00007920 File Offset: 0x00005B20
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00007928 File Offset: 0x00005B28
		[XmlElement(DataType = "integer")]
		public string KeySize
		{
			get
			{
				return this.keySizeField;
			}
			set
			{
				this.keySizeField = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00007931 File Offset: 0x00005B31
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00007939 File Offset: 0x00005B39
		[XmlElement(DataType = "base64Binary")]
		public byte[] OAEPparams
		{
			get
			{
				return this.oAEPparamsField;
			}
			set
			{
				this.oAEPparamsField = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00007942 File Offset: 0x00005B42
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0000794A File Offset: 0x00005B4A
		[XmlText]
		[XmlAnyElement]
		public XmlNode[] Any
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00007953 File Offset: 0x00005B53
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0000795B File Offset: 0x00005B5B
		[XmlAttribute(DataType = "anyURI")]
		public string Algorithm
		{
			get
			{
				return this.algorithmField;
			}
			set
			{
				this.algorithmField = value;
			}
		}

		// Token: 0x04000128 RID: 296
		private string keySizeField;

		// Token: 0x04000129 RID: 297
		private byte[] oAEPparamsField;

		// Token: 0x0400012A RID: 298
		private XmlNode[] anyField;

		// Token: 0x0400012B RID: 299
		private string algorithmField;
	}
}
