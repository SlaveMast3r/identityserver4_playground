using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000071 RID: 113
	[XmlInclude(typeof(SPSSODescriptorType))]
	[XmlInclude(typeof(IDPSSODescriptorType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[Serializable]
	public abstract class SSODescriptorType : RoleDescriptorType
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00007D89 File Offset: 0x00005F89
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00007D91 File Offset: 0x00005F91
		[XmlElement("ArtifactResolutionService")]
		public IndexedEndpointType[] ArtifactResolutionService
		{
			get
			{
				return this.artifactResolutionServiceField;
			}
			set
			{
				this.artifactResolutionServiceField = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00007D9A File Offset: 0x00005F9A
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00007DA2 File Offset: 0x00005FA2
		[XmlElement("SingleLogoutService")]
		public EndpointType[] SingleLogoutService
		{
			get
			{
				return this.singleLogoutServiceField;
			}
			set
			{
				this.singleLogoutServiceField = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00007DAB File Offset: 0x00005FAB
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00007DB3 File Offset: 0x00005FB3
		[XmlElement("ManageNameIDService")]
		public EndpointType[] ManageNameIDService
		{
			get
			{
				return this.manageNameIDServiceField;
			}
			set
			{
				this.manageNameIDServiceField = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00007DBC File Offset: 0x00005FBC
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00007DC4 File Offset: 0x00005FC4
		[XmlElement("NameIDFormat", DataType = "anyURI")]
		public string[] NameIDFormat
		{
			get
			{
				return this.nameIDFormatField;
			}
			set
			{
				this.nameIDFormatField = value;
			}
		}

		// Token: 0x04000172 RID: 370
		private IndexedEndpointType[] artifactResolutionServiceField;

		// Token: 0x04000173 RID: 371
		private EndpointType[] singleLogoutServiceField;

		// Token: 0x04000174 RID: 372
		private EndpointType[] manageNameIDServiceField;

		// Token: 0x04000175 RID: 373
		private string[] nameIDFormatField;
	}
}
