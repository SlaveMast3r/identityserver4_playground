using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000068 RID: 104
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[Serializable]
	public enum ContactTypeType
	{
		// Token: 0x04000147 RID: 327
		technical,
		// Token: 0x04000148 RID: 328
		support,
		// Token: 0x04000149 RID: 329
		administrative,
		// Token: 0x0400014A RID: 330
		billing,
		// Token: 0x0400014B RID: 331
		other
	}
}
