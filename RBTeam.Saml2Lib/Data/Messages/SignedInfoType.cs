using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200005A RID: 90
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class SignedInfoType
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002CB RID: 715 RVA: 0x000077CC File Offset: 0x000059CC
		// (set) Token: 0x060002CC RID: 716 RVA: 0x000077D4 File Offset: 0x000059D4
		public CanonicalizationMethodType CanonicalizationMethod
		{
			get
			{
				return this.canonicalizationMethodField;
			}
			set
			{
				this.canonicalizationMethodField = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000077DD File Offset: 0x000059DD
		// (set) Token: 0x060002CE RID: 718 RVA: 0x000077E5 File Offset: 0x000059E5
		public SignatureMethodType SignatureMethod
		{
			get
			{
				return this.signatureMethodField;
			}
			set
			{
				this.signatureMethodField = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000077EE File Offset: 0x000059EE
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x000077F6 File Offset: 0x000059F6
		[XmlElement("Reference")]
		public ReferenceType[] Reference
		{
			get
			{
				return this.referenceField;
			}
			set
			{
				this.referenceField = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x000077FF File Offset: 0x000059FF
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00007807 File Offset: 0x00005A07
		[XmlAttribute(DataType = "ID")]
		public string Id
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

		// Token: 0x04000114 RID: 276
		private CanonicalizationMethodType canonicalizationMethodField;

		// Token: 0x04000115 RID: 277
		private SignatureMethodType signatureMethodField;

		// Token: 0x04000116 RID: 278
		private ReferenceType[] referenceField;

		// Token: 0x04000117 RID: 279
		private string idField;
	}
}
