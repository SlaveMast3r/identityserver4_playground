using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200003D RID: 61
	[XmlInclude(typeof(NameIDMappingRequestType))]
	[XmlInclude(typeof(LogoutRequestType))]
	[XmlInclude(typeof(ManageNameIDRequestType))]
	[XmlInclude(typeof(ArtifactResolveType))]
	[XmlInclude(typeof(AuthnRequestType))]
	[XmlInclude(typeof(SubjectQueryAbstractType))]
	[XmlInclude(typeof(AuthzDecisionQueryType))]
	[XmlInclude(typeof(AttributeQueryType))]
	[XmlInclude(typeof(AuthnQueryType))]
	[XmlInclude(typeof(AssertionIDRequestType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[Serializable]
	public abstract class RequestAbstractType : ISaml2Message
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00006FBB File Offset: 0x000051BB
		protected RequestAbstractType()
		{
			this.Version = "2.0";
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00006FCE File Offset: 0x000051CE
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00006FDB File Offset: 0x000051DB
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00006FE9 File Offset: 0x000051E9
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00006FF1 File Offset: 0x000051F1
		[XmlElement(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00006FFA File Offset: 0x000051FA
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00007002 File Offset: 0x00005202
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000700B File Offset: 0x0000520B
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00007013 File Offset: 0x00005213
		public ExtensionsType Extensions
		{
			get
			{
				return this.extensionsField;
			}
			set
			{
				this.extensionsField = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000701C File Offset: 0x0000521C
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00007024 File Offset: 0x00005224
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000702D File Offset: 0x0000522D
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00007035 File Offset: 0x00005235
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000703E File Offset: 0x0000523E
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00007046 File Offset: 0x00005246
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000704F File Offset: 0x0000524F
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00007057 File Offset: 0x00005257
		[XmlAttribute(DataType = "anyURI")]
		public string Destination
		{
			get
			{
				return this.destinationField;
			}
			set
			{
				this.destinationField = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00007060 File Offset: 0x00005260
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00007068 File Offset: 0x00005268
		[XmlAttribute(DataType = "anyURI")]
		public string Consent
		{
			get
			{
				return this.consentField;
			}
			set
			{
				this.consentField = value;
			}
		}

		// Token: 0x040000A1 RID: 161
		private NameIDType issuerField;

		// Token: 0x040000A2 RID: 162
		private SignatureType signatureField;

		// Token: 0x040000A3 RID: 163
		private ExtensionsType extensionsField;

		// Token: 0x040000A4 RID: 164
		private string idField;

		// Token: 0x040000A5 RID: 165
		private string versionField;

		// Token: 0x040000A6 RID: 166
		private DateTime issueInstantField;

		// Token: 0x040000A7 RID: 167
		private string destinationField;

		// Token: 0x040000A8 RID: 168
		private string consentField;
	}
}
