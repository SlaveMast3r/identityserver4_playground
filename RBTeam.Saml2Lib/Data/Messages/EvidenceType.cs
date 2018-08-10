using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000075 RID: 117
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("Evidence", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class EvidenceType
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00007F3A File Offset: 0x0000613A
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00007F42 File Offset: 0x00006142
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

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00007F4B File Offset: 0x0000614B
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00007F53 File Offset: 0x00006153
		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType6[] ItemsElementName
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

		// Token: 0x0400018B RID: 395
		private object[] itemsField;

		// Token: 0x0400018C RID: 396
		private ItemsChoiceType6[] itemsElementNameField;
	}
}
