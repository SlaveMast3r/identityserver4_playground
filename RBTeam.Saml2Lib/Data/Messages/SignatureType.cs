using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000059 RID: 89
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class SignatureType
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00007777 File Offset: 0x00005977
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000777F File Offset: 0x0000597F
		public SignedInfoType SignedInfo
		{
			get
			{
				return this.signedInfoField;
			}
			set
			{
				this.signedInfoField = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00007788 File Offset: 0x00005988
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00007790 File Offset: 0x00005990
		public SignatureValueType SignatureValue
		{
			get
			{
				return this.signatureValueField;
			}
			set
			{
				this.signatureValueField = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00007799 File Offset: 0x00005999
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000077A1 File Offset: 0x000059A1
		public KeyInfoType KeyInfo
		{
			get
			{
				return this.keyInfoField;
			}
			set
			{
				this.keyInfoField = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000077AA File Offset: 0x000059AA
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000077B2 File Offset: 0x000059B2
		[XmlElement("Object")]
		public ObjectType[] Object
		{
			get
			{
				return this.objectField;
			}
			set
			{
				this.objectField = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000077BB File Offset: 0x000059BB
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x000077C3 File Offset: 0x000059C3
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

		// Token: 0x0400010F RID: 271
		private SignedInfoType signedInfoField;

		// Token: 0x04000110 RID: 272
		private SignatureValueType signatureValueField;

		// Token: 0x04000111 RID: 273
		private KeyInfoType keyInfoField;

		// Token: 0x04000112 RID: 274
		private ObjectType[] objectField;

		// Token: 0x04000113 RID: 275
		private string idField;
	}
}
