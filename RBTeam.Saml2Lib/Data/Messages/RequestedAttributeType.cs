using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000065 RID: 101
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:metadata")]
	[XmlRoot("RequestedAttribute", Namespace = "urn:oasis:names:tc:SAML:2.0:metadata", IsNullable = false)]
	[Serializable]
	public class RequestedAttributeType : AttributeType
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000079EC File Offset: 0x00005BEC
		// (set) Token: 0x06000316 RID: 790 RVA: 0x000079F4 File Offset: 0x00005BF4
		[XmlAttribute]
		public bool isRequired
		{
			get
			{
				return this.isRequiredField;
			}
			set
			{
				this.isRequiredField = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000079FD File Offset: 0x00005BFD
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00007A05 File Offset: 0x00005C05
		[XmlIgnore]
		public bool isRequiredSpecified
		{
			get
			{
				return this.isRequiredFieldSpecified;
			}
			set
			{
				this.isRequiredFieldSpecified = value;
			}
		}

		// Token: 0x04000137 RID: 311
		private bool isRequiredField;

		// Token: 0x04000138 RID: 312
		private bool isRequiredFieldSpecified;
	}
}
