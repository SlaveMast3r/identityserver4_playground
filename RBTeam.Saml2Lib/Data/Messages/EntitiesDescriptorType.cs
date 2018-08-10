using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000074 RID: 116
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("EntitiesDescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class EntitiesDescriptorType
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00007EB2 File Offset: 0x000060B2
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00007EBA File Offset: 0x000060BA
		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureType Signature
		{
			get
			{
				return this.signatureField;
			}
			set
			{
				this.signatureField = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00007EC3 File Offset: 0x000060C3
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00007ECB File Offset: 0x000060CB
		public ExtensionsType1 Extensions
		{
			get
			{
				return this.extensionsField;
			}
			set
			{
				this.extensionsField = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00007ED4 File Offset: 0x000060D4
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00007EDC File Offset: 0x000060DC
		[XmlElement("EntitiesDescriptor", typeof(EntitiesDescriptorType))]
		[XmlElement("EntityDescriptor", typeof(EntityDescriptorType))]
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00007EE5 File Offset: 0x000060E5
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00007EED File Offset: 0x000060ED
		[XmlAttribute]
		public DateTime validUntil
		{
			get
			{
				return this.validUntilField;
			}
			set
			{
				this.validUntilField = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00007EF6 File Offset: 0x000060F6
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00007EFE File Offset: 0x000060FE
		[XmlIgnore]
		public bool validUntilSpecified
		{
			get
			{
				return this.validUntilFieldSpecified;
			}
			set
			{
				this.validUntilFieldSpecified = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00007F07 File Offset: 0x00006107
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00007F0F File Offset: 0x0000610F
		[XmlAttribute(DataType = "duration")]
		public string cacheDuration
		{
			get
			{
				return this.cacheDurationField;
			}
			set
			{
				this.cacheDurationField = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00007F18 File Offset: 0x00006118
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00007F20 File Offset: 0x00006120
		[XmlAttribute(DataType = "ID")]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00007F29 File Offset: 0x00006129
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00007F31 File Offset: 0x00006131
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

		// Token: 0x04000183 RID: 387
		private SignatureType signatureField;

		// Token: 0x04000184 RID: 388
		private ExtensionsType1 extensionsField;

		// Token: 0x04000185 RID: 389
		private object[] itemsField;

		// Token: 0x04000186 RID: 390
		private DateTime validUntilField;

		// Token: 0x04000187 RID: 391
		private bool validUntilFieldSpecified;

		// Token: 0x04000188 RID: 392
		private string cacheDurationField;

		// Token: 0x04000189 RID: 393
		private string idField;

		// Token: 0x0400018A RID: 394
		private string nameField;
	}
}
