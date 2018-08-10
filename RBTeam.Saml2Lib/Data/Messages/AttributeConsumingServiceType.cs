using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000063 RID: 99
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("AttributeConsumingService", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class AttributeConsumingServiceType
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00007964 File Offset: 0x00005B64
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0000796C File Offset: 0x00005B6C
		[XmlElement("ServiceName")]
		public localizedNameType[] ServiceName
		{
			get
			{
				return this.serviceNameField;
			}
			set
			{
				this.serviceNameField = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00007975 File Offset: 0x00005B75
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000797D File Offset: 0x00005B7D
		[XmlElement("ServiceDescription")]
		public localizedNameType[] ServiceDescription
		{
			get
			{
				return this.serviceDescriptionField;
			}
			set
			{
				this.serviceDescriptionField = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00007986 File Offset: 0x00005B86
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0000798E File Offset: 0x00005B8E
		[XmlElement("RequestedAttribute")]
		public RequestedAttributeType[] RequestedAttribute
		{
			get
			{
				return this.requestedAttributeField;
			}
			set
			{
				this.requestedAttributeField = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00007997 File Offset: 0x00005B97
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000799F File Offset: 0x00005B9F
		[XmlAttribute]
		public ushort index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600030B RID: 779 RVA: 0x000079A8 File Offset: 0x00005BA8
		// (set) Token: 0x0600030C RID: 780 RVA: 0x000079B0 File Offset: 0x00005BB0
		[XmlAttribute]
		public bool isDefault
		{
			get
			{
				return this.isDefaultField;
			}
			set
			{
				this.isDefaultField = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000079B9 File Offset: 0x00005BB9
		// (set) Token: 0x0600030E RID: 782 RVA: 0x000079C1 File Offset: 0x00005BC1
		[XmlIgnore]
		public bool isDefaultSpecified
		{
			get
			{
				return this.isDefaultFieldSpecified;
			}
			set
			{
				this.isDefaultFieldSpecified = value;
			}
		}

		// Token: 0x0400012F RID: 303
		private localizedNameType[] serviceNameField;

		// Token: 0x04000130 RID: 304
		private localizedNameType[] serviceDescriptionField;

		// Token: 0x04000131 RID: 305
		private RequestedAttributeType[] requestedAttributeField;

		// Token: 0x04000132 RID: 306
		private ushort indexField;

		// Token: 0x04000133 RID: 307
		private bool isDefaultField;

		// Token: 0x04000134 RID: 308
		private bool isDefaultFieldSpecified;
	}
}
