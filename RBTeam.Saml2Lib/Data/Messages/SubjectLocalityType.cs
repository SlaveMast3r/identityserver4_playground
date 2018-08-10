using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000091 RID: 145
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("SubjectLocality", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class SubjectLocalityType
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000832C File Offset: 0x0000652C
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00008334 File Offset: 0x00006534
		[XmlAttribute]
		public string Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000833D File Offset: 0x0000653D
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00008345 File Offset: 0x00006545
		[XmlAttribute]
		public string DNSName
		{
			get
			{
				return this.dNSNameField;
			}
			set
			{
				this.dNSNameField = value;
			}
		}

		// Token: 0x040001D2 RID: 466
		private string addressField;

		// Token: 0x040001D3 RID: 467
		private string dNSNameField;
	}
}
