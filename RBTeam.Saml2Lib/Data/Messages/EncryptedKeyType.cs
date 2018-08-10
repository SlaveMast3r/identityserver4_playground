using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000080 RID: 128
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[XmlRoot("EncryptedKey", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
	[Serializable]
	public class EncryptedKeyType : EncryptedType
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00008140 File Offset: 0x00006340
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00008148 File Offset: 0x00006348
		public ReferenceList ReferenceList
		{
			get
			{
				return this.referenceListField;
			}
			set
			{
				this.referenceListField = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00008151 File Offset: 0x00006351
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00008159 File Offset: 0x00006359
		public string CarriedKeyName
		{
			get
			{
				return this.carriedKeyNameField;
			}
			set
			{
				this.carriedKeyNameField = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00008162 File Offset: 0x00006362
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0000816A File Offset: 0x0000636A
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

		// Token: 0x040001A9 RID: 425
		private ReferenceList referenceListField;

		// Token: 0x040001AA RID: 426
		private string carriedKeyNameField;

		// Token: 0x040001AB RID: 427
		private string recipientField;
	}
}
