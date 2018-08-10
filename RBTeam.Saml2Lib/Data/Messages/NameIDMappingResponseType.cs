using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x020000A9 RID: 169
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("NameIDMappingResponse", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class NameIDMappingResponseType : StatusResponseType
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000085ED File Offset: 0x000067ED
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x000085F5 File Offset: 0x000067F5
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

		// Token: 0x0400020C RID: 524
		private object itemField;
	}
}
