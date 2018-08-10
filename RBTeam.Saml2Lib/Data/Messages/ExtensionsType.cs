using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000042 RID: 66
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("Extensions", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class ExtensionsType
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00007340 File Offset: 0x00005540
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00007348 File Offset: 0x00005548
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

		// Token: 0x040000BC RID: 188
		private XmlElement[] anyField;
	}
}
