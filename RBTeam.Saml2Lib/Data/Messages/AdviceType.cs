using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000089 RID: 137
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("Advice", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class AdviceType
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00008225 File Offset: 0x00006425
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0000822D File Offset: 0x0000642D
		[XmlAnyElement]
		[XmlElement("Assertion", typeof(AssertionType))]
		[XmlElement("AssertionIDRef", typeof(string), DataType = "NCName")]
		[XmlElement("AssertionURIRef", typeof(string), DataType = "anyURI")]
		[XmlElement("EncryptedAssertion", typeof(EncryptedElementType))]
		[XmlChoiceIdentifier("ItemsElementName")]
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00008236 File Offset: 0x00006436
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0000823E File Offset: 0x0000643E
		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType4[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		// Token: 0x040001B9 RID: 441
		private object[] itemsField;

		// Token: 0x040001BA RID: 442
		private ItemsChoiceType4[] itemsElementNameField;
	}
}
