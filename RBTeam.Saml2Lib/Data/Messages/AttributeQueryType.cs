using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200009E RID: 158
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("AttributeQuery", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class AttributeQueryType : SubjectQueryAbstractType
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00008477 File Offset: 0x00006677
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0000847F File Offset: 0x0000667F
		[XmlElement("Attribute", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public AttributeType[] Attribute
		{
			get
			{
				return this.attributeField;
			}
			set
			{
				this.attributeField = value;
			}
		}

		// Token: 0x040001F6 RID: 502
		private AttributeType[] attributeField;
	}
}
