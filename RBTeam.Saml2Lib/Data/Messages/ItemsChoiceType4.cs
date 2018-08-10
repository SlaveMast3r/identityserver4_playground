using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200008A RID: 138
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType4
	{
		// Token: 0x040001BC RID: 444
		[XmlEnum("##any:")]
		Item,
		// Token: 0x040001BD RID: 445
		Assertion,
		// Token: 0x040001BE RID: 446
		AssertionIDRef,
		// Token: 0x040001BF RID: 447
		AssertionURIRef,
		// Token: 0x040001C0 RID: 448
		EncryptedAssertion
	}
}
