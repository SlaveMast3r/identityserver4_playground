using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200008B RID: 139
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("AttributeStatement", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class AttributeStatementType : StatementAbstractType
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00008247 File Offset: 0x00006447
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000824F File Offset: 0x0000644F
		[XmlElement("Attribute", typeof(AttributeType))]
		[XmlElement("EncryptedAttribute", typeof(EncryptedElementType))]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x040001C1 RID: 449
		private object[] itemsField;
	}
}
