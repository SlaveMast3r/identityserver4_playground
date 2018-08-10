using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x02000038 RID: 56
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:protocol")]
	[XmlRoot("AuthnRequest", Namespace = "urn:oasis:names:tc:SAML:2.0:protocol", IsNullable = false)]
	[Serializable]
	public class AuthnRequestType : RequestAbstractType
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00006C64 File Offset: 0x00004E64
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00006C6C File Offset: 0x00004E6C
		[XmlElement(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public SubjectType Subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00006C75 File Offset: 0x00004E75
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00006C7D File Offset: 0x00004E7D
		public NameIDPolicyType NameIDPolicy
		{
			get
			{
				return this.nameIDPolicyField;
			}
			set
			{
				this.nameIDPolicyField = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00006C86 File Offset: 0x00004E86
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00006C8E File Offset: 0x00004E8E
		[XmlElement(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
		public ConditionsType Conditions
		{
			get
			{
				return this.conditionsField;
			}
			set
			{
				this.conditionsField = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00006C97 File Offset: 0x00004E97
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00006C9F File Offset: 0x00004E9F
		public RequestedAuthnContextType RequestedAuthnContext
		{
			get
			{
				return this.requestedAuthnContextField;
			}
			set
			{
				this.requestedAuthnContextField = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00006CA8 File Offset: 0x00004EA8
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00006CB0 File Offset: 0x00004EB0
		public ScopingType Scoping
		{
			get
			{
				return this.scopingField;
			}
			set
			{
				this.scopingField = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00006CB9 File Offset: 0x00004EB9
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00006CC1 File Offset: 0x00004EC1
		[XmlAttribute]
		public bool ForceAuthn
		{
			get
			{
				return this.forceAuthnField;
			}
			set
			{
				this.forceAuthnField = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00006CCA File Offset: 0x00004ECA
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00006CD2 File Offset: 0x00004ED2
		[XmlIgnore]
		public bool ForceAuthnSpecified
		{
			get
			{
				return this.forceAuthnFieldSpecified;
			}
			set
			{
				this.forceAuthnFieldSpecified = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00006CDB File Offset: 0x00004EDB
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00006CE3 File Offset: 0x00004EE3
		[XmlAttribute]
		public bool IsPassive
		{
			get
			{
				return this.isPassiveField;
			}
			set
			{
				this.isPassiveField = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00006CEC File Offset: 0x00004EEC
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00006CF4 File Offset: 0x00004EF4
		[XmlIgnore]
		public bool IsPassiveSpecified
		{
			get
			{
				return this.isPassiveFieldSpecified;
			}
			set
			{
				this.isPassiveFieldSpecified = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00006CFD File Offset: 0x00004EFD
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00006D05 File Offset: 0x00004F05
		[XmlAttribute(DataType = "anyURI")]
		public string ProtocolBinding
		{
			get
			{
				return this.protocolBindingField;
			}
			set
			{
				this.protocolBindingField = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00006D0E File Offset: 0x00004F0E
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00006D16 File Offset: 0x00004F16
		[XmlAttribute]
		public ushort AssertionConsumerServiceIndex
		{
			get
			{
				return this.assertionConsumerServiceIndexField;
			}
			set
			{
				this.assertionConsumerServiceIndexField = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00006D1F File Offset: 0x00004F1F
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00006D27 File Offset: 0x00004F27
		[XmlIgnore]
		public bool AssertionConsumerServiceIndexSpecified
		{
			get
			{
				return this.assertionConsumerServiceIndexFieldSpecified;
			}
			set
			{
				this.assertionConsumerServiceIndexFieldSpecified = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00006D30 File Offset: 0x00004F30
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00006D38 File Offset: 0x00004F38
		[XmlAttribute(DataType = "anyURI")]
		public string AssertionConsumerServiceURL
		{
			get
			{
				return this.assertionConsumerServiceURLField;
			}
			set
			{
				this.assertionConsumerServiceURLField = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00006D41 File Offset: 0x00004F41
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00006D49 File Offset: 0x00004F49
		[XmlAttribute]
		public ushort AttributeConsumingServiceIndex
		{
			get
			{
				return this.attributeConsumingServiceIndexField;
			}
			set
			{
				this.attributeConsumingServiceIndexField = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00006D52 File Offset: 0x00004F52
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00006D5A File Offset: 0x00004F5A
		[XmlIgnore]
		public bool AttributeConsumingServiceIndexSpecified
		{
			get
			{
				return this.attributeConsumingServiceIndexFieldSpecified;
			}
			set
			{
				this.attributeConsumingServiceIndexFieldSpecified = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00006D63 File Offset: 0x00004F63
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00006D6B File Offset: 0x00004F6B
		[XmlAttribute]
		public string ProviderName
		{
			get
			{
				return this.providerNameField;
			}
			set
			{
				this.providerNameField = value;
			}
		}

		// Token: 0x0400007B RID: 123
		private SubjectType subjectField;

		// Token: 0x0400007C RID: 124
		private NameIDPolicyType nameIDPolicyField;

		// Token: 0x0400007D RID: 125
		private ConditionsType conditionsField;

		// Token: 0x0400007E RID: 126
		private RequestedAuthnContextType requestedAuthnContextField;

		// Token: 0x0400007F RID: 127
		private ScopingType scopingField;

		// Token: 0x04000080 RID: 128
		private bool forceAuthnField;

		// Token: 0x04000081 RID: 129
		private bool forceAuthnFieldSpecified;

		// Token: 0x04000082 RID: 130
		private bool isPassiveField;

		// Token: 0x04000083 RID: 131
		private bool isPassiveFieldSpecified;

		// Token: 0x04000084 RID: 132
		private string protocolBindingField;

		// Token: 0x04000085 RID: 133
		private ushort assertionConsumerServiceIndexField;

		// Token: 0x04000086 RID: 134
		private bool assertionConsumerServiceIndexFieldSpecified;

		// Token: 0x04000087 RID: 135
		private string assertionConsumerServiceURLField;

		// Token: 0x04000088 RID: 136
		private ushort attributeConsumingServiceIndexField;

		// Token: 0x04000089 RID: 137
		private bool attributeConsumingServiceIndexFieldSpecified;

		// Token: 0x0400008A RID: 138
		private string providerNameField;
	}
}
