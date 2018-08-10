using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200004E RID: 78
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class X509DataType
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00007557 File Offset: 0x00005757
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0000755F File Offset: 0x0000575F
		[XmlAnyElement]
		[XmlElement("X509CRL", typeof(byte[]), DataType = "base64Binary")]
		[XmlElement("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
		[XmlElement("X509IssuerSerial", typeof(X509IssuerSerialType))]
		[XmlElement("X509SKI", typeof(byte[]), DataType = "base64Binary")]
		[XmlElement("X509SubjectName", typeof(string))]
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00007568 File Offset: 0x00005768
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00007570 File Offset: 0x00005770
		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType[] ItemsElementName
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

		// Token: 0x040000DF RID: 223
		private object[] itemsField;

		// Token: 0x040000E0 RID: 224
		private ItemsChoiceType[] itemsElementNameField;
	}
}
