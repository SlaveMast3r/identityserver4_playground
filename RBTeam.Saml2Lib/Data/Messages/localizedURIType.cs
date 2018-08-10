using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000069 RID: 105
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("OrganizationURL", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class localizedURIType
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00007AF3 File Offset: 0x00005CF3
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00007AFB File Offset: 0x00005CFB
		[XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00007B04 File Offset: 0x00005D04
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00007B0C File Offset: 0x00005D0C
		[XmlText(DataType = "anyURI")]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x0400014C RID: 332
		private string langField;

		// Token: 0x0400014D RID: 333
		private string valueField;
	}
}
