using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000058 RID: 88
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("AffiliationDescriptor", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class AffiliationDescriptorType
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000076CD File Offset: 0x000058CD
		// (set) Token: 0x060002AC RID: 684 RVA: 0x000076D5 File Offset: 0x000058D5
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000076DE File Offset: 0x000058DE
		// (set) Token: 0x060002AE RID: 686 RVA: 0x000076E6 File Offset: 0x000058E6
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002AF RID: 687 RVA: 0x000076EF File Offset: 0x000058EF
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x000076F7 File Offset: 0x000058F7
		[XmlElement("AffiliateMember", DataType = "anyURI")]
		public string[] AffiliateMember
		{
			get
			{
				return this.affiliateMemberField;
			}
			set
			{
				this.affiliateMemberField = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00007700 File Offset: 0x00005900
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00007708 File Offset: 0x00005908
		[XmlElement("KeyDescriptor")]
		public KeyDescriptorType[] KeyDescriptor
		{
			get
			{
				return this.keyDescriptorField;
			}
			set
			{
				this.keyDescriptorField = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00007711 File Offset: 0x00005911
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00007719 File Offset: 0x00005919
		[XmlAttribute(DataType = "anyURI")]
		public string affiliationOwnerID
		{
			get
			{
				return this.affiliationOwnerIDField;
			}
			set
			{
				this.affiliationOwnerIDField = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00007722 File Offset: 0x00005922
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000772A File Offset: 0x0000592A
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00007733 File Offset: 0x00005933
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0000773B File Offset: 0x0000593B
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00007744 File Offset: 0x00005944
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000774C File Offset: 0x0000594C
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00007755 File Offset: 0x00005955
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000775D File Offset: 0x0000595D
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00007766 File Offset: 0x00005966
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0000776E File Offset: 0x0000596E
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

		// Token: 0x04000105 RID: 261
		private SignatureType signatureField;

		// Token: 0x04000106 RID: 262
		private ExtensionsType1 extensionsField;

		// Token: 0x04000107 RID: 263
		private string[] affiliateMemberField;

		// Token: 0x04000108 RID: 264
		private KeyDescriptorType[] keyDescriptorField;

		// Token: 0x04000109 RID: 265
		private string affiliationOwnerIDField;

		// Token: 0x0400010A RID: 266
		private DateTime validUntilField;

		// Token: 0x0400010B RID: 267
		private bool validUntilFieldSpecified;

		// Token: 0x0400010C RID: 268
		private string cacheDurationField;

		// Token: 0x0400010D RID: 269
		private string idField;

		// Token: 0x0400010E RID: 270
		private XmlAttribute[] anyAttrField;
	}
}
