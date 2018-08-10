using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000098 RID: 152
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("AssertionIDRequest", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class AssertionIDRequestType : RequestAbstractType
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x000083E7 File Offset: 0x000065E7
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x000083EF File Offset: 0x000065EF
		[XmlElement("AssertionIDRef", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", DataType = "NCName")]
		public string[] AssertionIDRef
		{
			get
			{
				return this.assertionIDRefField;
			}
			set
			{
				this.assertionIDRefField = value;
			}
		}

		// Token: 0x040001E6 RID: 486
		private string[] assertionIDRefField;
	}
}
