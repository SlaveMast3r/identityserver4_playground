using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200007E RID: 126
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[XmlRoot("EncryptionProperties", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
	[Serializable]
	public class EncryptionPropertiesType
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000080C9 File Offset: 0x000062C9
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x000080D1 File Offset: 0x000062D1
		[XmlElement("EncryptionProperty")]
		public EncryptionPropertyType[] EncryptionProperty
		{
			get
			{
				return this.encryptionPropertyField;
			}
			set
			{
				this.encryptionPropertyField = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000080DA File Offset: 0x000062DA
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x000080E2 File Offset: 0x000062E2
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

		// Token: 0x040001A2 RID: 418
		private EncryptionPropertyType[] encryptionPropertyField;

		// Token: 0x040001A3 RID: 419
		private string idField;
	}
}
