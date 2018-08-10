using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200007A RID: 122
	[XmlInclude(typeof(EncryptedKeyType))]
	[XmlInclude(typeof(EncryptedDataType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[Serializable]
	public abstract class EncryptedType
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00007FFD File Offset: 0x000061FD
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00008005 File Offset: 0x00006205
		public EncryptionMethodType EncryptionMethod
		{
			get
			{
				return this.encryptionMethodField;
			}
			set
			{
				this.encryptionMethodField = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000800E File Offset: 0x0000620E
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00008016 File Offset: 0x00006216
		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000801F File Offset: 0x0000621F
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00008027 File Offset: 0x00006227
		public CipherDataType CipherData
		{
			get
			{
				return this.cipherDataField;
			}
			set
			{
				this.cipherDataField = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00008030 File Offset: 0x00006230
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00008038 File Offset: 0x00006238
		public EncryptionPropertiesType EncryptionProperties
		{
			get
			{
				return this.encryptionPropertiesField;
			}
			set
			{
				this.encryptionPropertiesField = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00008041 File Offset: 0x00006241
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00008049 File Offset: 0x00006249
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00008052 File Offset: 0x00006252
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x0000805A File Offset: 0x0000625A
		[XmlAttribute(DataType = "anyURI")]
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00008063 File Offset: 0x00006263
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x0000806B File Offset: 0x0000626B
		[XmlAttribute]
		public string MimeType
		{
			get
			{
				return this.mimeTypeField;
			}
			set
			{
				this.mimeTypeField = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00008074 File Offset: 0x00006274
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0000807C File Offset: 0x0000627C
		[XmlAttribute(DataType = "anyURI")]
		public string Encoding
		{
			get
			{
				return this.encodingField;
			}
			set
			{
				this.encodingField = value;
			}
		}

		// Token: 0x04000196 RID: 406
		private EncryptionMethodType encryptionMethodField;

		// Token: 0x04000197 RID: 407
		private KeyInfoType keyInfoField;

		// Token: 0x04000198 RID: 408
		private CipherDataType cipherDataField;

		// Token: 0x04000199 RID: 409
		private EncryptionPropertiesType encryptionPropertiesField;

		// Token: 0x0400019A RID: 410
		private string idField;

		// Token: 0x0400019B RID: 411
		private string typeField;

		// Token: 0x0400019C RID: 412
		private string mimeTypeField;

		// Token: 0x0400019D RID: 413
		private string encodingField;
	}
}
