using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200009B RID: 155
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("RequestedAuthnContext", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class RequestedAuthnContextType
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00008433 File Offset: 0x00006633
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0000843B File Offset: 0x0000663B
		[XmlElement("AuthnContextClassRef", typeof(string), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", DataType = "anyURI")]
		[XmlElement("AuthnContextDeclRef", typeof(string), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", DataType = "anyURI")]
		[XmlChoiceIdentifier("ItemsElementName")]
		public string[] Items
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

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00008444 File Offset: 0x00006644
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x0000844C File Offset: 0x0000664C
		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public AuthnContextRefType[] ItemsElementName
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

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00008455 File Offset: 0x00006655
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x0000845D File Offset: 0x0000665D
		[XmlAttribute]
		public AuthnContextComparisonType Comparison
		{
			get
			{
				return this.comparisonField;
			}
			set
			{
				this.comparisonField = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00008466 File Offset: 0x00006666
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x0000846E File Offset: 0x0000666E
		[XmlIgnore]
		public bool ComparisonSpecified
		{
			get
			{
				return this.comparisonFieldSpecified;
			}
			set
			{
				this.comparisonFieldSpecified = value;
			}
		}

		// Token: 0x040001EA RID: 490
		private string[] itemsField;

		// Token: 0x040001EB RID: 491
		private AuthnContextRefType[] itemsElementNameField;

		// Token: 0x040001EC RID: 492
		private AuthnContextComparisonType comparisonField;

		// Token: 0x040001ED RID: 493
		private bool comparisonFieldSpecified;
	}
}
