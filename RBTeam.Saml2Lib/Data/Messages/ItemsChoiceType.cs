using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000050 RID: 80
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType
	{
		// Token: 0x040000E4 RID: 228
		[XmlEnum("##any:")]
		Item,
		// Token: 0x040000E5 RID: 229
		X509CRL,
		// Token: 0x040000E6 RID: 230
		X509Certificate,
		// Token: 0x040000E7 RID: 231
		X509IssuerSerial,
		// Token: 0x040000E8 RID: 232
		X509SKI,
		// Token: 0x040000E9 RID: 233
		X509SubjectName
	}
}
