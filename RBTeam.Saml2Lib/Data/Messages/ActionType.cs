using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200008E RID: 142
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("Action", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class ActionType
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x000082A4 File Offset: 0x000064A4
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x000082AC File Offset: 0x000064AC
		[XmlAttribute(DataType = "anyURI")]
		public string Namespace
		{
			get
			{
				return this.namespaceField;
			}
			set
			{
				this.namespaceField = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x000082B5 File Offset: 0x000064B5
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x000082BD File Offset: 0x000064BD
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

		// Token: 0x040001C6 RID: 454
		private string namespaceField;

		// Token: 0x040001C7 RID: 455
		private string valueField;
	}
}
