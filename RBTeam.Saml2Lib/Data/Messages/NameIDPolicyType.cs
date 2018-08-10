using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A0 RID: 160
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("NameIDPolicy", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class NameIDPolicyType
	{
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x000084BB File Offset: 0x000066BB
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x000084C3 File Offset: 0x000066C3
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

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x000084CC File Offset: 0x000066CC
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x000084D4 File Offset: 0x000066D4
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

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x000084DD File Offset: 0x000066DD
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x000084E5 File Offset: 0x000066E5
		[XmlAttribute]
		public bool AllowCreate
		{
			get
			{
				return this.allowCreateField;
			}
			set
			{
				this.allowCreateField = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x000084EE File Offset: 0x000066EE
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x000084F6 File Offset: 0x000066F6
		[XmlIgnore]
		public bool AllowCreateSpecified
		{
			get
			{
				return this.allowCreateFieldSpecified;
			}
			set
			{
				this.allowCreateFieldSpecified = value;
			}
		}

		// Token: 0x040001FA RID: 506
		private string formatField;

		// Token: 0x040001FB RID: 507
		private string sPNameQualifierField;

		// Token: 0x040001FC RID: 508
		private bool allowCreateField;

		// Token: 0x040001FD RID: 509
		private bool allowCreateFieldSpecified;
	}
}
