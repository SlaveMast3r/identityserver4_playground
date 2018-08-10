using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200009C RID: 156
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IncludeInSchema = false)]
	[Serializable]
	public enum AuthnContextRefType
	{
		// Token: 0x040001EF RID: 495
		[XmlEnum("urn:oasis:names:tc:SAML:2.0:assertion:AuthnContextClassRef")]
		AuthnContextClassRef,
		// Token: 0x040001F0 RID: 496
		[XmlEnum("urn:oasis:names:tc:SAML:2.0:assertion:AuthnContextDeclRef")]
		AuthnContextDeclRef
	}
}
