using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A5 RID: 165
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("ArtifactResponse", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class ArtifactResponseType : StatusResponseType
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00008598 File Offset: 0x00006798
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x000085A0 File Offset: 0x000067A0
		[XmlAnyElement]
		public XmlElement Any
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

		// Token: 0x04000207 RID: 519
		private XmlElement anyField;
	}
}
