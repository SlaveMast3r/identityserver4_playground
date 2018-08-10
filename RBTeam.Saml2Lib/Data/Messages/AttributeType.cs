using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000066 RID: 102
	[XmlInclude(typeof(RequestedAttributeType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("Attribute", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class AttributeType
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00007A16 File Offset: 0x00005C16
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00007A1E File Offset: 0x00005C1E
		[XmlElement("AttributeValue", IsNullable = true)]
		public object[] AttributeValue
		{
			get
			{
				return this.attributeValueField;
			}
			set
			{
				this.attributeValueField = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00007A27 File Offset: 0x00005C27
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00007A2F File Offset: 0x00005C2F
		[XmlAttribute]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00007A38 File Offset: 0x00005C38
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00007A40 File Offset: 0x00005C40
		[XmlAttribute(DataType = "anyURI")]
		public string NameFormat
		{
			get
			{
				return this.nameFormatField;
			}
			set
			{
				this.nameFormatField = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00007A49 File Offset: 0x00005C49
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00007A51 File Offset: 0x00005C51
		[XmlAttribute]
		public string FriendlyName
		{
			get
			{
				return this.friendlyNameField;
			}
			set
			{
				this.friendlyNameField = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00007A5A File Offset: 0x00005C5A
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00007A62 File Offset: 0x00005C62
		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.anyAttrField;
			}
			set
			{
				this.anyAttrField = value;
			}
		}

		// Token: 0x04000139 RID: 313
		private object[] attributeValueField;

		// Token: 0x0400013A RID: 314
		private string nameField;

		// Token: 0x0400013B RID: 315
		private string nameFormatField;

		// Token: 0x0400013C RID: 316
		private string friendlyNameField;

		// Token: 0x0400013D RID: 317
		private XmlAttribute[] anyAttrField;
	}
}
