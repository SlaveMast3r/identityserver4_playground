using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200008D RID: 141
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("AuthzDecisionStatement", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class AuthzDecisionStatementType : StatementAbstractType
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00008260 File Offset: 0x00006460
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00008268 File Offset: 0x00006468
		[XmlElement("Action")]
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00008271 File Offset: 0x00006471
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00008279 File Offset: 0x00006479
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00008282 File Offset: 0x00006482
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0000828A File Offset: 0x0000648A
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00008293 File Offset: 0x00006493
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0000829B File Offset: 0x0000649B
		[XmlAttribute]
		public DecisionType Decision
		{
			get
			{
				return this.decisionField;
			}
			set
			{
				this.decisionField = value;
			}
		}

		// Token: 0x040001C2 RID: 450
		private ActionType[] actionField;

		// Token: 0x040001C3 RID: 451
		private EvidenceType evidenceField;

		// Token: 0x040001C4 RID: 452
		private string resourceField;

		// Token: 0x040001C5 RID: 453
		private DecisionType decisionField;
	}
}
