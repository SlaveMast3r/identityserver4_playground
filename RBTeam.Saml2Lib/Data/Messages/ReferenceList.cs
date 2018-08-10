using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000081 RID: 129
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[XmlRoot(Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
	[Serializable]
	public class ReferenceList
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00008173 File Offset: 0x00006373
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0000817B File Offset: 0x0000637B
		[XmlElement("DataReference", typeof(ReferenceType1))]
		[XmlElement("KeyReference", typeof(ReferenceType1))]
		[XmlChoiceIdentifier("ItemsElementName")]
		public ReferenceType1[] Items
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00008184 File Offset: 0x00006384
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0000818C File Offset: 0x0000638C
		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType3[] ItemsElementName
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

		// Token: 0x040001AC RID: 428
		private ReferenceType1[] itemsField;

		// Token: 0x040001AD RID: 429
		private ItemsChoiceType3[] itemsElementNameField;
	}
}
