using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A8 RID: 168
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("NameIDMappingRequest", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class NameIDMappingRequestType : RequestAbstractType
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000085CB File Offset: 0x000067CB
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x000085D3 File Offset: 0x000067D3
		[XmlElement("BaseID", typeof(BaseIDAbstractType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		[XmlElement("EncryptedID", typeof(EncryptedElementType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		[XmlElement("NameID", typeof(NameIDType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000085DC File Offset: 0x000067DC
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x000085E4 File Offset: 0x000067E4
		public NameIDPolicyType NameIDPolicy
		{
			get
			{
				return this.nameIDPolicyField;
			}
			set
			{
				this.nameIDPolicyField = value;
			}
		}

		// Token: 0x0400020A RID: 522
		private object itemField;

		// Token: 0x0400020B RID: 523
		private NameIDPolicyType nameIDPolicyField;
	}
}
