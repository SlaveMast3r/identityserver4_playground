using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000047 RID: 71
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class DSAKeyValueType
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00007414 File Offset: 0x00005614
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000741C File Offset: 0x0000561C
		[XmlElement(DataType = "base64Binary")]
		public byte[] P
		{
			get
			{
				return this.pField;
			}
			set
			{
				this.pField = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00007425 File Offset: 0x00005625
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000742D File Offset: 0x0000562D
		[XmlElement(DataType = "base64Binary")]
		public byte[] Q
		{
			get
			{
				return this.qField;
			}
			set
			{
				this.qField = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00007436 File Offset: 0x00005636
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000743E File Offset: 0x0000563E
		[XmlElement(DataType = "base64Binary")]
		public byte[] G
		{
			get
			{
				return this.gField;
			}
			set
			{
				this.gField = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00007447 File Offset: 0x00005647
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000744F File Offset: 0x0000564F
		[XmlElement(DataType = "base64Binary")]
		public byte[] Y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.yField = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00007458 File Offset: 0x00005658
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00007460 File Offset: 0x00005660
		[XmlElement(DataType = "base64Binary")]
		public byte[] J
		{
			get
			{
				return this.jField;
			}
			set
			{
				this.jField = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00007469 File Offset: 0x00005669
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00007471 File Offset: 0x00005671
		[XmlElement(DataType = "base64Binary")]
		public byte[] Seed
		{
			get
			{
				return this.seedField;
			}
			set
			{
				this.seedField = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000747A File Offset: 0x0000567A
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00007482 File Offset: 0x00005682
		[XmlElement(DataType = "base64Binary")]
		public byte[] PgenCounter
		{
			get
			{
				return this.pgenCounterField;
			}
			set
			{
				this.pgenCounterField = value;
			}
		}

		// Token: 0x040000C8 RID: 200
		private byte[] pField;

		// Token: 0x040000C9 RID: 201
		private byte[] qField;

		// Token: 0x040000CA RID: 202
		private byte[] gField;

		// Token: 0x040000CB RID: 203
		private byte[] yField;

		// Token: 0x040000CC RID: 204
		private byte[] jField;

		// Token: 0x040000CD RID: 205
		private byte[] seedField;

		// Token: 0x040000CE RID: 206
		private byte[] pgenCounterField;
	}
}
