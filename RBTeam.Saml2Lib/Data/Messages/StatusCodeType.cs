using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000096 RID: 150
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("StatusCode", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class StatusCodeType
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x000083B4 File Offset: 0x000065B4
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x000083BC File Offset: 0x000065BC
		public StatusCodeType StatusCode
		{
			get
			{
				return this.statusCodeField;
			}
			set
			{
				this.statusCodeField = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x000083C5 File Offset: 0x000065C5
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x000083CD File Offset: 0x000065CD
		[XmlAttribute(DataType = "anyURI")]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		// Token: 0x040001E3 RID: 483
		private StatusCodeType statusCodeField;

		// Token: 0x040001E4 RID: 484
		private string valueField;
	}
}
