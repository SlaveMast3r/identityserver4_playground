using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000094 RID: 148
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType6
	{
		// Token: 0x040001DC RID: 476
		Assertion,
		// Token: 0x040001DD RID: 477
		AssertionIDRef,
		// Token: 0x040001DE RID: 478
		AssertionURIRef,
		// Token: 0x040001DF RID: 479
		EncryptedAssertion
	}
}
