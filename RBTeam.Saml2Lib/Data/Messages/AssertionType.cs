using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000037 RID: 55
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("Assertion", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class AssertionType
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00006AD7 File Offset: 0x00004CD7
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00006AE4 File Offset: 0x00004CE4
		[XmlAttribute("IssueInstant")]
		public string CustomIssueInstant
		{
			get
			{
				return MessageUtility.DateToString(this.issueInstantField);
			}
			set
			{
				this.issueInstantField = MessageUtility.DateFromString(value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00006AF4 File Offset: 0x00004CF4
		public AuthnStatementType AuthnStatement
		{
			get
			{
				if (this.Items == null || this.Items.Length == 0)
				{
					return null;
				}
				return (AuthnStatementType)this.Items.FirstOrDefault((StatementAbstractType item) => item is AuthnStatementType);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00006B44 File Offset: 0x00004D44
		public string AuthnContextClassRef
		{
			get
			{
				AuthnStatementType authnStatement = this.AuthnStatement;
				bool flag;
				if (authnStatement == null)
				{
					flag = (null != null);
				}
				else
				{
					AuthnContextType authnContext = authnStatement.AuthnContext;
					flag = (((authnContext != null) ? authnContext.Items : null) != null);
				}
				if (!flag || this.AuthnStatement.AuthnContext.Items.Length == 0)
				{
					return null;
				}
				return this.AuthnStatement.AuthnContext.Items[0] as string;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00006BA0 File Offset: 0x00004DA0
		internal AssertionAttributes Attributes
		{
			get
			{
				AssertionAttributes result;
				if ((result = this.attributes) == null)
				{
					result = (this.attributes = new AssertionAttributes(this.Items));
				}
				return result;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00006BCB File Offset: 0x00004DCB
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00006BD3 File Offset: 0x00004DD3
		public NameIDType Issuer
		{
			get
			{
				return this.issuerField;
			}
			set
			{
				this.issuerField = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00006BDC File Offset: 0x00004DDC
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00006BE4 File Offset: 0x00004DE4
		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureType Signature
		{
			get
			{
				return this.signatureField;
			}
			set
			{
				this.signatureField = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00006BED File Offset: 0x00004DED
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00006BF5 File Offset: 0x00004DF5
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00006BFE File Offset: 0x00004DFE
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00006C06 File Offset: 0x00004E06
		public ConditionsType Conditions
		{
			get
			{
				return this.conditionsField;
			}
			set
			{
				this.conditionsField = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00006C0F File Offset: 0x00004E0F
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00006C17 File Offset: 0x00004E17
		public AdviceType Advice
		{
			get
			{
				return this.adviceField;
			}
			set
			{
				this.adviceField = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00006C20 File Offset: 0x00004E20
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00006C28 File Offset: 0x00004E28
		[XmlElement("AttributeStatement", typeof(AttributeStatementType))]
		[XmlElement("AuthnStatement", typeof(AuthnStatementType))]
		[XmlElement("AuthzDecisionStatement", typeof(AuthzDecisionStatementType))]
		[XmlElement("Statement", typeof(StatementAbstractType))]
		public StatementAbstractType[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00006C31 File Offset: 0x00004E31
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00006C39 File Offset: 0x00004E39
		[XmlAttribute]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00006C42 File Offset: 0x00004E42
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00006C4A File Offset: 0x00004E4A
		[XmlAttribute(DataType = "ID")]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00006C53 File Offset: 0x00004E53
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00006C5B File Offset: 0x00004E5B
		[XmlIgnore]
		public DateTime IssueInstant
		{
			get
			{
				return this.issueInstantField;
			}
			set
			{
				this.issueInstantField = value;
			}
		}

		// Token: 0x04000071 RID: 113
		private AssertionAttributes attributes;

		// Token: 0x04000072 RID: 114
		private NameIDType issuerField;

		// Token: 0x04000073 RID: 115
		private SignatureType signatureField;

		// Token: 0x04000074 RID: 116
		private SubjectType subjectField;

		// Token: 0x04000075 RID: 117
		private ConditionsType conditionsField;

		// Token: 0x04000076 RID: 118
		private AdviceType adviceField;

		// Token: 0x04000077 RID: 119
		private StatementAbstractType[] itemsField;

		// Token: 0x04000078 RID: 120
		private string versionField;

		// Token: 0x04000079 RID: 121
		private string idField;

		// Token: 0x0400007A RID: 122
		private DateTime issueInstantField;
	}
}
