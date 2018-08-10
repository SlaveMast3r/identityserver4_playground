using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000039 RID: 57
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("Conditions", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public class ConditionsType
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00006D7C File Offset: 0x00004F7C
		public AudienceRestrictionType AudienceRestriction
		{
			get
			{
				if (this.Items == null || this.Items.Length == 0)
				{
					return null;
				}
				return (AudienceRestrictionType)this.Items.FirstOrDefault((ConditionAbstractType item) => item is AudienceRestrictionType);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00006DCB File Offset: 0x00004FCB
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00006DD3 File Offset: 0x00004FD3
		[XmlElement("AudienceRestriction", typeof(AudienceRestrictionType))]
		[XmlElement("Condition", typeof(ConditionAbstractType))]
		[XmlElement("OneTimeUse", typeof(OneTimeUseType))]
		[XmlElement("ProxyRestriction", typeof(ProxyRestrictionType))]
		public ConditionAbstractType[] Items
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00006DDC File Offset: 0x00004FDC
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00006DE4 File Offset: 0x00004FE4
		[XmlAttribute]
		public DateTime NotBefore
		{
			get
			{
				return this.notBeforeField;
			}
			set
			{
				this.notBeforeField = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00006DED File Offset: 0x00004FED
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00006DF5 File Offset: 0x00004FF5
		[XmlIgnore]
		public bool NotBeforeSpecified
		{
			get
			{
				return this.notBeforeFieldSpecified;
			}
			set
			{
				this.notBeforeFieldSpecified = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00006DFE File Offset: 0x00004FFE
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00006E06 File Offset: 0x00005006
		[XmlAttribute]
		public DateTime NotOnOrAfter
		{
			get
			{
				return this.notOnOrAfterField;
			}
			set
			{
				this.notOnOrAfterField = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006E0F File Offset: 0x0000500F
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00006E17 File Offset: 0x00005017
		[XmlIgnore]
		public bool NotOnOrAfterSpecified
		{
			get
			{
				return this.notOnOrAfterFieldSpecified;
			}
			set
			{
				this.notOnOrAfterFieldSpecified = value;
			}
		}

		// Token: 0x0400008B RID: 139
		private ConditionAbstractType[] itemsField;

		// Token: 0x0400008C RID: 140
		private DateTime notBeforeField;

		// Token: 0x0400008D RID: 141
		private bool notBeforeFieldSpecified;

		// Token: 0x0400008E RID: 142
		private DateTime notOnOrAfterField;

		// Token: 0x0400008F RID: 143
		private bool notOnOrAfterFieldSpecified;
	}
}
