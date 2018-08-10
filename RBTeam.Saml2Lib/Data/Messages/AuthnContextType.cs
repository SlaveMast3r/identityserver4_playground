using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000092 RID: 146
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("AuthnContext", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class AuthnContextType
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0000834E File Offset: 0x0000654E
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00008356 File Offset: 0x00006556
		[XmlElement("AuthnContextClassRef", typeof(string), DataType = "anyURI")]
		[XmlElement("AuthnContextDecl", typeof(object))]
		[XmlElement("AuthnContextDeclRef", typeof(string), DataType = "anyURI")]
		[XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
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

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000835F File Offset: 0x0000655F
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00008367 File Offset: 0x00006567
		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType5[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00008370 File Offset: 0x00006570
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00008378 File Offset: 0x00006578
		[XmlElement("AuthenticatingAuthority", DataType = "anyURI")]
		public string[] AuthenticatingAuthority
		{
			get
			{
				return this.authenticatingAuthorityField;
			}
			set
			{
				this.authenticatingAuthorityField = value;
			}
		}

		// Token: 0x040001D4 RID: 468
		private object[] itemsField;

		// Token: 0x040001D5 RID: 469
		private ItemsChoiceType5[] itemsElementNameField;

		// Token: 0x040001D6 RID: 470
		private string[] authenticatingAuthorityField;
	}
}
