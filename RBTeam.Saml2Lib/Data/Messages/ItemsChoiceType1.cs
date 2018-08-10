using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200004A RID: 74
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType1
	{
		// Token: 0x040000D4 RID: 212
		[XmlEnum("##any:")]
		Item,
		// Token: 0x040000D5 RID: 213
		PGPKeyID,
		// Token: 0x040000D6 RID: 214
		PGPKeyPacket
	}
}
