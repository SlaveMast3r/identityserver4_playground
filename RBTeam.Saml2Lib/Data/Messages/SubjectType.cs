using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000041 RID: 65
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("Subject", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class SubjectType
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00007290 File Offset: 0x00005490
		public NameIDType NameID
		{
			get
			{
				if (this.Items == null || this.Items.Length == 0)
				{
					return null;
				}
				return (NameIDType)this.Items.FirstOrDefault((object item) => item is NameIDType);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000072E0 File Offset: 0x000054E0
		public SubjectConfirmationType SubjectConfirmation
		{
			get
			{
				if (this.Items == null || this.Items.Length == 0)
				{
					return null;
				}
				return (SubjectConfirmationType)this.Items.FirstOrDefault((object item) => item is SubjectConfirmationType);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000732F File Offset: 0x0000552F
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00007337 File Offset: 0x00005537
		[XmlElement("BaseID", typeof(BaseIDAbstractType))]
		[XmlElement("EncryptedID", typeof(EncryptedElementType))]
		[XmlElement("NameID", typeof(NameIDType))]
		[XmlElement("SubjectConfirmation", typeof(SubjectConfirmationType))]
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

		// Token: 0x040000BB RID: 187
		private object[] itemsField;
	}
}
