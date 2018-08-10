using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200009D RID: 157
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[Serializable]
	public enum AuthnContextComparisonType
	{
		// Token: 0x040001F2 RID: 498
		exact,
		// Token: 0x040001F3 RID: 499
		minimum,
		// Token: 0x040001F4 RID: 500
		maximum,
		// Token: 0x040001F5 RID: 501
		better
	}
}
