using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200008F RID: 143
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[Serializable]
	public enum DecisionType
	{
		// Token: 0x040001C9 RID: 457
		Permit,
		// Token: 0x040001CA RID: 458
		Deny,
		// Token: 0x040001CB RID: 459
		Indeterminate
	}
}
