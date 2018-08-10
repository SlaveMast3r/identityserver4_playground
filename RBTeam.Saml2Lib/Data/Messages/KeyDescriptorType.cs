using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000060 RID: 96
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("KeyDescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class KeyDescriptorType
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000078DC File Offset: 0x00005ADC
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000078E4 File Offset: 0x00005AE4
		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public KeyInfoType KeyInfo
		{
			get
			{
				return this.keyInfoField;
			}
			set
			{
				this.keyInfoField = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x000078ED File Offset: 0x00005AED
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x000078F5 File Offset: 0x00005AF5
		[XmlElement("EncryptionMethod")]
		public EncryptionMethodType[] EncryptionMethod
		{
			get
			{
				return this.encryptionMethodField;
			}
			set
			{
				this.encryptionMethodField = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000078FE File Offset: 0x00005AFE
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00007906 File Offset: 0x00005B06
		[XmlAttribute]
		public KeyTypes use
		{
			get
			{
				return this.useField;
			}
			set
			{
				this.useField = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000790F File Offset: 0x00005B0F
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00007917 File Offset: 0x00005B17
		[XmlIgnore]
		public bool useSpecified
		{
			get
			{
				return this.useFieldSpecified;
			}
			set
			{
				this.useFieldSpecified = value;
			}
		}

		// Token: 0x04000124 RID: 292
		private KeyInfoType keyInfoField;

		// Token: 0x04000125 RID: 293
		private EncryptionMethodType[] encryptionMethodField;

		// Token: 0x04000126 RID: 294
		private KeyTypes useField;

		// Token: 0x04000127 RID: 295
		private bool useFieldSpecified;
	}
}
