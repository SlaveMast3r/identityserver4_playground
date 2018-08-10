using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000040 RID: 64
	[XmlInclude(typeof(KeyInfoConfirmationDataType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("SubjectConfirmationData", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class SubjectConfirmationDataType
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000071F2 File Offset: 0x000053F2
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000071FA File Offset: 0x000053FA
		[XmlIgnore]
		public DateTime NotBefore
		{
			get
			{
				return this.notBeforeField;
			}
			set
			{
				this.notBeforeField = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00007203 File Offset: 0x00005403
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00007210 File Offset: 0x00005410
		[XmlAttribute("NotBefore")]
		public string CustomNotBefore
		{
			get
			{
				return MessageUtility.DateToString(this.notBeforeField);
			}
			set
			{
				this.notBeforeField = MessageUtility.DateFromString(value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000721E File Offset: 0x0000541E
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00007226 File Offset: 0x00005426
		[XmlIgnore]
		public bool NotBeforeSpecified
		{
			get
			{
				return this.notBeforeFieldSpecified;
			}
			set
			{
				this.notBeforeFieldSpecified = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000722F File Offset: 0x0000542F
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00007237 File Offset: 0x00005437
		[XmlIgnore]
		public DateTime NotOnOrAfter
		{
			get
			{
				return this.notOnOrAfterField;
			}
			set
			{
				this.notOnOrAfterField = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00007240 File Offset: 0x00005440
		// (set) Token: 0x06000221 RID: 545 RVA: 0x0000724D File Offset: 0x0000544D
		[XmlAttribute("NotOnOrAfter")]
		public string CustomNotOnOrAfter
		{
			get
			{
				return MessageUtility.DateToString(this.notOnOrAfterField);
			}
			set
			{
				this.notOnOrAfterField = MessageUtility.DateFromString(value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000725B File Offset: 0x0000545B
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00007263 File Offset: 0x00005463
		[XmlIgnore]
		public bool NotOnOrAfterSpecified
		{
			get
			{
				return this.notOnOrAfterFieldSpecified;
			}
			set
			{
				this.notOnOrAfterFieldSpecified = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000726C File Offset: 0x0000546C
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00007274 File Offset: 0x00005474
		[XmlAttribute]
		public string Recipient
		{
			get
			{
				return this.recipientField;
			}
			set
			{
				this.recipientField = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000727D File Offset: 0x0000547D
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00007285 File Offset: 0x00005485
		[XmlText]
		public string[] Text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
			}
		}

		// Token: 0x040000B5 RID: 181
		private DateTime notBeforeField;

		// Token: 0x040000B6 RID: 182
		private bool notBeforeFieldSpecified;

		// Token: 0x040000B7 RID: 183
		private DateTime notOnOrAfterField;

		// Token: 0x040000B8 RID: 184
		private bool notOnOrAfterFieldSpecified;

		// Token: 0x040000B9 RID: 185
		private string recipientField;

		// Token: 0x040000BA RID: 186
		private string[] textField;
	}
}
