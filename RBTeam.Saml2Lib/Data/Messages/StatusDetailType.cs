using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000097 RID: 151
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("StatusDetail", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class StatusDetailType
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000083D6 File Offset: 0x000065D6
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x000083DE File Offset: 0x000065DE
		[XmlAnyElement]
		public XmlElement[] Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
			}
		}

		// Token: 0x040001E5 RID: 485
		private XmlElement[] anyField;
	}
}
