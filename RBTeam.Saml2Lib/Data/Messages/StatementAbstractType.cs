using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RBTeam.Saml2Lib.Data.Messages
{
	// Token: 0x0200008C RID: 140
	[XmlInclude(typeof(AttributeStatementType))]
	[XmlInclude(typeof(AuthzDecisionStatementType))]
	[XmlInclude(typeof(AuthnStatementType))]
	[GeneratedCode("xsd", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:tc:SAML:2.0:assertion")]
	[XmlRoot("Statement", Namespace = "urn:oasis:names:tc:SAML:2.0:assertion", IsNullable = false)]
	[Serializable]
	public abstract class StatementAbstractType
	{
	}
}
