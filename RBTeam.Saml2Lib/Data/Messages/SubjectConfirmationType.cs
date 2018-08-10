using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000084 RID: 132
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("SubjectConfirmation", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class SubjectConfirmationType
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x000081B7 File Offset: 0x000063B7
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x000081BF File Offset: 0x000063BF
		[XmlElement("BaseID", typeof(BaseIDAbstractType))]
		[XmlElement("EncryptedID", typeof(EncryptedElementType))]
		[XmlElement("NameID", typeof(NameIDType))]
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x000081C8 File Offset: 0x000063C8
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x000081D0 File Offset: 0x000063D0
		public SubjectConfirmationDataType SubjectConfirmationData
		{
			get
			{
				return this.subjectConfirmationDataField;
			}
			set
			{
				this.subjectConfirmationDataField = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000081D9 File Offset: 0x000063D9
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000081E1 File Offset: 0x000063E1
		[XmlAttribute(DataType = "anyURI")]
		public string Method
		{
			get
			{
				return this.methodField;
			}
			set
			{
				this.methodField = value;
			}
		}

		// Token: 0x040001B3 RID: 435
		private object itemField;

		// Token: 0x040001B4 RID: 436
		private SubjectConfirmationDataType subjectConfirmationDataField;

		// Token: 0x040001B5 RID: 437
		private string methodField;
	}
}
