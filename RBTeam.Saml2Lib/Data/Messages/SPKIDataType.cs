using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200004D RID: 77
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	[XmlRoot("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
	[Serializable]
	public class SPKIDataType
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00007535 File Offset: 0x00005735
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0000753D File Offset: 0x0000573D
		[XmlElement("SPKISexp", DataType = "base64Binary")]
		public byte[][] SPKISexp
		{
			get
			{
				return this.sPKISexpField;
			}
			set
			{
				this.sPKISexpField = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00007546 File Offset: 0x00005746
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0000754E File Offset: 0x0000574E
		[XmlAnyElement]
		public XmlElement Any
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

		// Token: 0x040000DD RID: 221
		private byte[][] sPKISexpField;

		// Token: 0x040000DE RID: 222
		private XmlElement anyField;
	}
}
