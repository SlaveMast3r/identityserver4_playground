using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A4 RID: 164
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("ArtifactResolve", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class ArtifactResolveType : RequestAbstractType
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00008587 File Offset: 0x00006787
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0000858F File Offset: 0x0000678F
		public string Artifact
		{
			get
			{
				return this.artifactField;
			}
			set
			{
				this.artifactField = value;
			}
		}

		// Token: 0x04000206 RID: 518
		private string artifactField;
	}
}
