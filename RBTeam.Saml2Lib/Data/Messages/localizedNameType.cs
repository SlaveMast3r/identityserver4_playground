using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000064 RID: 100
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("OrganizationName", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class localizedNameType
	{
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000079CA File Offset: 0x00005BCA
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000079D2 File Offset: 0x00005BD2
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000079DB File Offset: 0x00005BDB
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000079E3 File Offset: 0x00005BE3
		[XmlText]
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

		// Token: 0x04000135 RID: 309
		private string langField;

		// Token: 0x04000136 RID: 310
		private string valueField;
	}
}
