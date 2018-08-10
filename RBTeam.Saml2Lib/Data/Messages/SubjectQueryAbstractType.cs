using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000099 RID: 153
	[XmlInclude(typeof(AuthzDecisionQueryType))]
	[XmlInclude(typeof(AttributeQueryType))]
	[XmlInclude(typeof(AuthnQueryType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("SubjectQuery", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public abstract class SubjectQueryAbstractType : RequestAbstractType
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x000083F8 File Offset: 0x000065F8
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00008400 File Offset: 0x00006600
		[XmlElement(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public SubjectType Subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
			}
		}

		// Token: 0x040001E7 RID: 487
		private SubjectType subjectField;
	}
}
