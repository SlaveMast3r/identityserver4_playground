using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200003F RID: 63
	[XmlInclude(typeof(NameIDMappingResponseType))]
	[XmlInclude(typeof(ArtifactResponseType))]
	[XmlInclude(typeof(ResponseType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("ManageNameIDResponse", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class StatusResponseType : ISaml2ResponseMessage, ISaml2Message
	{
		// Token: 0x060001FD RID: 509 RVA: 0x00007101 File Offset: 0x00005301
		public StatusResponseType()
		{
			this.Version = "2.0";
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00007114 File Offset: 0x00005314
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00007121 File Offset: 0x00005321
		[XmlAttribute("IssueInstant")]
		public string CustomSerializedIssueInstant
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000712F File Offset: 0x0000532F
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00007137 File Offset: 0x00005337
		[XmlIgnore]
		public string StatusCode
		{
			get
			{
				return MessageUtility.GetResponseStatus(this);
			}
			set
			{
				MessageUtility.SetResponseStatus(this, value);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00007140 File Offset: 0x00005340
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00007137 File Offset: 0x00005337
		[XmlIgnore]
		public string SecondLevelStatusCode
		{
			get
			{
				return MessageUtility.GetSecondLevelResponseStatus(this);
			}
			set
			{
				MessageUtility.SetResponseStatus(this, value);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00007148 File Offset: 0x00005348
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00007150 File Offset: 0x00005350
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00007159 File Offset: 0x00005359
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00007161 File Offset: 0x00005361
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000716A File Offset: 0x0000536A
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00007172 File Offset: 0x00005372
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000717B File Offset: 0x0000537B
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00007183 File Offset: 0x00005383
		public StatusType Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000718C File Offset: 0x0000538C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00007194 File Offset: 0x00005394
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000719D File Offset: 0x0000539D
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000071A5 File Offset: 0x000053A5
		[XmlAttribute(DataType = "NCName")]
		public string InResponseTo
		{
			get
			{
				return this.inResponseToField;
			}
			set
			{
				this.inResponseToField = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000071AE File Offset: 0x000053AE
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000071B6 File Offset: 0x000053B6
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000071BF File Offset: 0x000053BF
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000071C7 File Offset: 0x000053C7
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000071D0 File Offset: 0x000053D0
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000071D8 File Offset: 0x000053D8
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000216 RID: 534 RVA: 0x000071E1 File Offset: 0x000053E1
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000071E9 File Offset: 0x000053E9
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

		// Token: 0x040000AB RID: 171
		private NameIDType issuerField;

		// Token: 0x040000AC RID: 172
		private SignatureType signatureField;

		// Token: 0x040000AD RID: 173
		private ExtensionsType extensionsField;

		// Token: 0x040000AE RID: 174
		private StatusType statusField;

		// Token: 0x040000AF RID: 175
		private string idField;

		// Token: 0x040000B0 RID: 176
		private string inResponseToField;

		// Token: 0x040000B1 RID: 177
		private string versionField;

		// Token: 0x040000B2 RID: 178
		private DateTime issueInstantField;

		// Token: 0x040000B3 RID: 179
		private string destinationField;

		// Token: 0x040000B4 RID: 180
		private string consentField;
	}
}
