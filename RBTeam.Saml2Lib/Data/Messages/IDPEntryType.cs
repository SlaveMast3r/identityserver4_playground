using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A3 RID: 163
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("IDPEntry", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class IDPEntryType
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00008554 File Offset: 0x00006754
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0000855C File Offset: 0x0000675C
		[XmlAttribute(DataType = "anyURI")]
		public string ProviderID
		{
			get
			{
				return this.providerIDField;
			}
			set
			{
				this.providerIDField = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00008565 File Offset: 0x00006765
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0000856D File Offset: 0x0000676D
		[XmlAttribute]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00008576 File Offset: 0x00006776
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0000857E File Offset: 0x0000677E
		[XmlAttribute(DataType = "anyURI")]
		public string Loc
		{
			get
			{
				return this.locField;
			}
			set
			{
				this.locField = value;
			}
		}

		// Token: 0x04000203 RID: 515
		private string providerIDField;

		// Token: 0x04000204 RID: 516
		private string nameField;

		// Token: 0x04000205 RID: 517
		private string locField;
	}
}
