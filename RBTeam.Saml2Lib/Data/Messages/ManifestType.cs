using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000054 RID: 84
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class ManifestType
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00007601 File Offset: 0x00005801
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00007609 File Offset: 0x00005809
		[XmlElement("Reference")]
		public ReferenceType[] Reference
		{
			get
			{
				return this.referenceField;
			}
			set
			{
				this.referenceField = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00007612 File Offset: 0x00005812
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0000761A File Offset: 0x0000581A
		[XmlAttribute(DataType = "ID")]
		public string Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x040000F9 RID: 249
		private ReferenceType[] referenceField;

		// Token: 0x040000FA RID: 250
		private string idField;
	}
}
