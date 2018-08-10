using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A1 RID: 161
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("Scoping", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class ScopingType
	{
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000084FF File Offset: 0x000066FF
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00008507 File Offset: 0x00006707
		public IDPListType IDPList
		{
			get
			{
				return this.iDPListField;
			}
			set
			{
				this.iDPListField = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00008510 File Offset: 0x00006710
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00008518 File Offset: 0x00006718
		[XmlElement("RequesterID", DataType = "anyURI")]
		public string[] RequesterID
		{
			get
			{
				return this.requesterIDField;
			}
			set
			{
				this.requesterIDField = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00008521 File Offset: 0x00006721
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00008529 File Offset: 0x00006729
		[XmlAttribute(DataType = "nonNegativeInteger")]
		public string ProxyCount
		{
			get
			{
				return this.proxyCountField;
			}
			set
			{
				this.proxyCountField = value;
			}
		}

		// Token: 0x040001FE RID: 510
		private IDPListType iDPListField;

		// Token: 0x040001FF RID: 511
		private string[] requesterIDField;

		// Token: 0x04000200 RID: 512
		private string proxyCountField;
	}
}
