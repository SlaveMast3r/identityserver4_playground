using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200006D RID: 109
	[XmlInclude(typeof(IndexedEndpointType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("SingleLogoutService", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class EndpointType
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00007C93 File Offset: 0x00005E93
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00007C9B File Offset: 0x00005E9B
		[XmlAnyElement]
		public XmlElement[] Any
		{
			get
			{
				return this.anyField;
			}
			set
			{
				this.anyField = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00007CA4 File Offset: 0x00005EA4
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00007CAC File Offset: 0x00005EAC
		[XmlAttribute(DataType = "anyURI")]
		public string Binding
		{
			get
			{
				return this.bindingField;
			}
			set
			{
				this.bindingField = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00007CB5 File Offset: 0x00005EB5
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00007CBD File Offset: 0x00005EBD
		[XmlAttribute(DataType = "anyURI")]
		public string Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00007CC6 File Offset: 0x00005EC6
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00007CCE File Offset: 0x00005ECE
		[XmlAttribute(DataType = "anyURI")]
		public string ResponseLocation
		{
			get
			{
				return this.responseLocationField;
			}
			set
			{
				this.responseLocationField = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00007CD7 File Offset: 0x00005ED7
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00007CDF File Offset: 0x00005EDF
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

		// Token: 0x04000164 RID: 356
		private XmlElement[] anyField;

		// Token: 0x04000165 RID: 357
		private string bindingField;

		// Token: 0x04000166 RID: 358
		private string locationField;

		// Token: 0x04000167 RID: 359
		private string responseLocationField;

		// Token: 0x04000168 RID: 360
		private XmlAttribute[] anyAttrField;
	}
}
