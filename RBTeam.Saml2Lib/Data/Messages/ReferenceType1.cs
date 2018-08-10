using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000082 RID: 130
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(TypeName = "ReferenceType", Namespace = "http://www.w3.org/2001/04/xmlenc#")]
	[Serializable]
	public class ReferenceType1
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00008195 File Offset: 0x00006395
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0000819D File Offset: 0x0000639D
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000081A6 File Offset: 0x000063A6
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x000081AE File Offset: 0x000063AE
		[XmlAttribute(DataType = "anyURI")]
		public string URI
		{
			get
			{
				return this.uRIField;
			}
			set
			{
				this.uRIField = value;
			}
		}

		// Token: 0x040001AE RID: 430
		private XmlElement[] anyField;

		// Token: 0x040001AF RID: 431
		private string uRIField;
	}
}
