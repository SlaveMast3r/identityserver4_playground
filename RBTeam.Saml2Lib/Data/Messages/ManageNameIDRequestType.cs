using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A6 RID: 166
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("ManageNameIDRequest", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class ManageNameIDRequestType : RequestAbstractType
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000085A9 File Offset: 0x000067A9
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x000085B1 File Offset: 0x000067B1
		[XmlElement("EncryptedID", typeof(EncryptedElementType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		[XmlElement("NameID", typeof(NameIDType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000085BA File Offset: 0x000067BA
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x000085C2 File Offset: 0x000067C2
		[XmlElement("NewEncryptedID", typeof(EncryptedElementType))]
		[XmlElement("NewID", typeof(string))]
		[XmlElement("Terminate", typeof(TerminateType))]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
			}
		}

		// Token: 0x04000208 RID: 520
		private object itemField;

		// Token: 0x04000209 RID: 521
		private object item1Field;
	}
}
