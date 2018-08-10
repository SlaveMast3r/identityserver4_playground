using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000093 RID: 147
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType5
	{
		// Token: 0x040001D8 RID: 472
		AuthnContextClassRef,
		// Token: 0x040001D9 RID: 473
		AuthnContextDecl,
		// Token: 0x040001DA RID: 474
		AuthnContextDeclRef
	}
}
