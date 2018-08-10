using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200003E RID: 62
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("Response", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class ResponseType : StatusResponseType
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00007071 File Offset: 0x00005271
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00007079 File Offset: 0x00005279
		public string AssertionRaw { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00007082 File Offset: 0x00005282
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x000070A4 File Offset: 0x000052A4
		public AssertionType Assertion
		{
			get
			{
				if (this.Items != null && this.Items.Length != 0)
				{
					return this.Items[0] as AssertionType;
				}
				return null;
			}
			set
			{
				if (this.Items == null || this.Items.Length != 1)
				{
					this.Items = new object[1];
				}
				this.Items[0] = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000070CE File Offset: 0x000052CE
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x000070A4 File Offset: 0x000052A4
		public EncryptedElementType EncryptedAssertion
		{
			get
			{
				if (this.Items != null && this.Items.Length != 0)
				{
					return this.Items[0] as EncryptedElementType;
				}
				return null;
			}
			set
			{
				if (this.Items == null || this.Items.Length != 1)
				{
					this.Items = new object[1];
				}
				this.Items[0] = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000070F0 File Offset: 0x000052F0
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000070F8 File Offset: 0x000052F8
		[XmlElement("Assertion", typeof(AssertionType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		[XmlElement("EncryptedAssertion", typeof(EncryptedElementType), Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
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

		// Token: 0x040000AA RID: 170
		private object[] itemsField;
	}
}
