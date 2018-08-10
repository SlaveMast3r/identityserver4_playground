using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000087 RID: 135
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("ProxyRestriction", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class ProxyRestrictionType : ConditionAbstractType
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00008203 File Offset: 0x00006403
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0000820B File Offset: 0x0000640B
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00008214 File Offset: 0x00006414
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x0000821C File Offset: 0x0000641C
		[XmlAttribute(DataType = "nonNegativeInteger")]
		public string Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x040001B7 RID: 439
		private string[] audienceField;

		// Token: 0x040001B8 RID: 440
		private string countField;
	}
}
