using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200009F RID: 159
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("AuthzDecisionQuery", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class AuthzDecisionQueryType : SubjectQueryAbstractType
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00008488 File Offset: 0x00006688
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00008490 File Offset: 0x00006690
		[XmlElement("Action", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public ActionType[] Action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00008499 File Offset: 0x00006699
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x000084A1 File Offset: 0x000066A1
		[XmlElement(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public EvidenceType Evidence
		{
			get
			{
				return this.evidenceField;
			}
			set
			{
				this.evidenceField = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x000084AA File Offset: 0x000066AA
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x000084B2 File Offset: 0x000066B2
		[XmlAttribute(DataType = "anyURI")]
		public string Resource
		{
			get
			{
				return this.resourceField;
			}
			set
			{
				this.resourceField = value;
			}
		}

		// Token: 0x040001F7 RID: 503
		private ActionType[] actionField;

		// Token: 0x040001F8 RID: 504
		private EvidenceType evidenceField;

		// Token: 0x040001F9 RID: 505
		private string resourceField;
	}
}
