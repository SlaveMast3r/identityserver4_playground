using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A2 RID: 162
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("IDPList", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class IDPListType
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00008532 File Offset: 0x00006732
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x0000853A File Offset: 0x0000673A
		[XmlElement("IDPEntry")]
		public IDPEntryType[] IDPEntry
		{
			get
			{
				return this.iDPEntryField;
			}
			set
			{
				this.iDPEntryField = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00008543 File Offset: 0x00006743
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x0000854B File Offset: 0x0000674B
		[XmlElement(DataType = "anyURI")]
		public string GetComplete
		{
			get
			{
				return this.getCompleteField;
			}
			set
			{
				this.getCompleteField = value;
			}
		}

		// Token: 0x04000201 RID: 513
		private IDPEntryType[] iDPEntryField;

		// Token: 0x04000202 RID: 514
		private string getCompleteField;
	}
}
