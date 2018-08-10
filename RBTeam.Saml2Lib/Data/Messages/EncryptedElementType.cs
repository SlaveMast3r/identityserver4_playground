using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000078 RID: 120
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("NewEncryptedID", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class EncryptedElementType
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00007FD3 File Offset: 0x000061D3
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00007FDB File Offset: 0x000061DB
		[XmlElement(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
		public EncryptedDataType EncryptedData
		{
			get
			{
				return this.encryptedDataField;
			}
			set
			{
				this.encryptedDataField = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00007FE4 File Offset: 0x000061E4
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00007FEC File Offset: 0x000061EC
		[XmlElement("EncryptedKey", Namespace = "http://www.w3.org/2001/04/xmlenc#")]
		public EncryptedKeyType[] EncryptedKey
		{
			get
			{
				return this.encryptedKeyField;
			}
			set
			{
				this.encryptedKeyField = value;
			}
		}

		// Token: 0x04000194 RID: 404
		private EncryptedDataType encryptedDataField;

		// Token: 0x04000195 RID: 405
		private EncryptedKeyType[] encryptedKeyField;
	}
}
