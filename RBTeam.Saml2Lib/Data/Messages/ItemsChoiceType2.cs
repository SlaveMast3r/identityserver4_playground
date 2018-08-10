using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000051 RID: 81
	[GeneratedCode("xsd", "4.0.30319.1")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType2
	{
		// Token: 0x040000EB RID: 235
		[XmlEnum("##any:")]
		Item,
		// Token: 0x040000EC RID: 236
		KeyName,
		// Token: 0x040000ED RID: 237
		KeyValue,
		// Token: 0x040000EE RID: 238
		MgmtData,
		// Token: 0x040000EF RID: 239
		PGPData,
		// Token: 0x040000F0 RID: 240
		RetrievalMethod,
		// Token: 0x040000F1 RID: 241
		SPKIData,
		// Token: 0x040000F2 RID: 242
		X509Data
	}
}
