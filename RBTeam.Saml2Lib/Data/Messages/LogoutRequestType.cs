using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200003B RID: 59
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("LogoutRequest", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class LogoutRequestType : RequestAbstractType
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00006F5E File Offset: 0x0000515E
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00006F66 File Offset: 0x00005166
		[XmlElement("BaseID", typeof(BaseIDAbstractType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		[XmlElement("EncryptedID", typeof(EncryptedElementType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		[XmlElement("NameID", typeof(NameIDType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00006F6F File Offset: 0x0000516F
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00006F77 File Offset: 0x00005177
		[XmlElement("SessionIndex")]
		public string[] SessionIndex
		{
			get
			{
				return this.sessionIndexField;
			}
			set
			{
				this.sessionIndexField = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00006F80 File Offset: 0x00005180
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00006F88 File Offset: 0x00005188
		[XmlAttribute]
		public string Reason
		{
			get
			{
				return this.reasonField;
			}
			set
			{
				this.reasonField = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00006F91 File Offset: 0x00005191
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00006F99 File Offset: 0x00005199
		[XmlAttribute]
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00006FA2 File Offset: 0x000051A2
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00006FAA File Offset: 0x000051AA
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

		// Token: 0x0400009C RID: 156
		private object itemField;

		// Token: 0x0400009D RID: 157
		private string[] sessionIndexField;

		// Token: 0x0400009E RID: 158
		private string reasonField;

		// Token: 0x0400009F RID: 159
		private DateTime notOnOrAfterField;

		// Token: 0x040000A0 RID: 160
		private bool notOnOrAfterFieldSpecified;
	}
}
