using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000044 RID: 68
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[XmlRoot("AgreementMethod", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
	[Serializable]
	public class AgreementMethodType
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00007359 File Offset: 0x00005559
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00007361 File Offset: 0x00005561
		[XmlElement("KA-Nonce", DataType = "base64Binary")]
		public byte[] KANonce
		{
			get
			{
				return this.kANonceField;
			}
			set
			{
				this.kANonceField = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000736A File Offset: 0x0000556A
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00007372 File Offset: 0x00005572
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000737B File Offset: 0x0000557B
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00007383 File Offset: 0x00005583
		public KeyInfoType OriginatorKeyInfo
		{
			get
			{
				return this.originatorKeyInfoField;
			}
			set
			{
				this.originatorKeyInfoField = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000738C File Offset: 0x0000558C
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00007394 File Offset: 0x00005594
		public KeyInfoType RecipientKeyInfo
		{
			get
			{
				return this.recipientKeyInfoField;
			}
			set
			{
				this.recipientKeyInfoField = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000739D File Offset: 0x0000559D
		// (set) Token: 0x0600023B RID: 571 RVA: 0x000073A5 File Offset: 0x000055A5
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

		// Token: 0x040000BD RID: 189
		private byte[] kANonceField;

		// Token: 0x040000BE RID: 190
		private XmlNode[] anyField;

		// Token: 0x040000BF RID: 191
		private KeyInfoType originatorKeyInfoField;

		// Token: 0x040000C0 RID: 192
		private KeyInfoType recipientKeyInfoField;

		// Token: 0x040000C1 RID: 193
		private string algorithmField;
	}
}
