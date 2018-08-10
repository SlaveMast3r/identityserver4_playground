using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000085 RID: 133
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("AudienceRestriction", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class AudienceRestrictionType : ConditionAbstractType
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x000081EA File Offset: 0x000063EA
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x000081F2 File Offset: 0x000063F2
		[XmlElement("Audience", DataType = "anyURI")]
		public string[] Audience
		{
			get
			{
				return this.audienceField;
			}
			set
			{
				this.audienceField = value;
			}
		}

		// Token: 0x040001B6 RID: 438
		private string[] audienceField;
	}
}
