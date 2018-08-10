using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000076 RID: 118
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("NameID", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class NameIDType
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00007F5C File Offset: 0x0000615C
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00007F64 File Offset: 0x00006164
		[XmlAttribute]
		public string NameQualifier
		{
			get
			{
				return this.nameQualifierField;
			}
			set
			{
				this.nameQualifierField = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00007F6D File Offset: 0x0000616D
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00007F75 File Offset: 0x00006175
		[XmlAttribute]
		public string SPNameQualifier
		{
			get
			{
				return this.sPNameQualifierField;
			}
			set
			{
				this.sPNameQualifierField = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00007F7E File Offset: 0x0000617E
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00007F86 File Offset: 0x00006186
		[XmlAttribute(DataType = "anyURI")]
		public string Format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00007F8F File Offset: 0x0000618F
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00007F97 File Offset: 0x00006197
		[XmlAttribute]
		public string SPProvidedID
		{
			get
			{
				return this.sPProvidedIDField;
			}
			set
			{
				this.sPProvidedIDField = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00007FA0 File Offset: 0x000061A0
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00007FA8 File Offset: 0x000061A8
		[XmlText]
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

		// Token: 0x0400018D RID: 397
		private string nameQualifierField;

		// Token: 0x0400018E RID: 398
		private string sPNameQualifierField;

		// Token: 0x0400018F RID: 399
		private string formatField;

		// Token: 0x04000190 RID: 400
		private string sPProvidedIDField;

		// Token: 0x04000191 RID: 401
		private string valueField;
	}
}
