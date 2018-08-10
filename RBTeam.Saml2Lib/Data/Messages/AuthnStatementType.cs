using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000090 RID: 144
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("AuthnStatement", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class AuthnStatementType : StatementAbstractType
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x000082C6 File Offset: 0x000064C6
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x000082CE File Offset: 0x000064CE
		public SubjectLocalityType SubjectLocality
		{
			get
			{
				return this.subjectLocalityField;
			}
			set
			{
				this.subjectLocalityField = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000082D7 File Offset: 0x000064D7
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x000082DF File Offset: 0x000064DF
		public AuthnContextType AuthnContext
		{
			get
			{
				return this.authnContextField;
			}
			set
			{
				this.authnContextField = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000082E8 File Offset: 0x000064E8
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x000082F0 File Offset: 0x000064F0
		[XmlAttribute]
		public DateTime AuthnInstant
		{
			get
			{
				return this.authnInstantField;
			}
			set
			{
				this.authnInstantField = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x000082F9 File Offset: 0x000064F9
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00008301 File Offset: 0x00006501
		[XmlAttribute]
		public string SessionIndex
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000830A File Offset: 0x0000650A
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00008312 File Offset: 0x00006512
		[XmlAttribute]
		public DateTime SessionNotOnOrAfter
		{
			get
			{
				return this.sessionNotOnOrAfterField;
			}
			set
			{
				this.sessionNotOnOrAfterField = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000831B File Offset: 0x0000651B
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00008323 File Offset: 0x00006523
		[XmlIgnore]
		public bool SessionNotOnOrAfterSpecified
		{
			get
			{
				return this.sessionNotOnOrAfterFieldSpecified;
			}
			set
			{
				this.sessionNotOnOrAfterFieldSpecified = value;
			}
		}

		// Token: 0x040001CC RID: 460
		private SubjectLocalityType subjectLocalityField;

		// Token: 0x040001CD RID: 461
		private AuthnContextType authnContextField;

		// Token: 0x040001CE RID: 462
		private DateTime authnInstantField;

		// Token: 0x040001CF RID: 463
		private string sessionIndexField;

		// Token: 0x040001D0 RID: 464
		private DateTime sessionNotOnOrAfterField;

		// Token: 0x040001D1 RID: 465
		private bool sessionNotOnOrAfterFieldSpecified;
	}
}
