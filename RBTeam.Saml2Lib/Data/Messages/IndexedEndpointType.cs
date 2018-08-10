using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200006E RID: 110
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("ArtifactResolutionService", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class IndexedEndpointType : EndpointType
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00007CE8 File Offset: 0x00005EE8
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00007CF0 File Offset: 0x00005EF0
		[XmlAttribute]
		public ushort index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00007CF9 File Offset: 0x00005EF9
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00007D01 File Offset: 0x00005F01
		[XmlAttribute]
		public bool isDefault
		{
			get
			{
				return this.isDefaultField;
			}
			set
			{
				this.isDefaultField = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00007D0A File Offset: 0x00005F0A
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00007D12 File Offset: 0x00005F12
		[XmlIgnore]
		public bool isDefaultSpecified
		{
			get
			{
				return this.isDefaultFieldSpecified;
			}
			set
			{
				this.isDefaultFieldSpecified = value;
			}
		}

		// Token: 0x04000169 RID: 361
		private ushort indexField;

		// Token: 0x0400016A RID: 362
		private bool isDefaultField;

		// Token: 0x0400016B RID: 363
		private bool isDefaultFieldSpecified;
	}
}
