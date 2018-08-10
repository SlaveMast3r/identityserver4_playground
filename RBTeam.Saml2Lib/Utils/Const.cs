using System;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x0200000C RID: 12
	internal static class Const
	{
		// Token: 0x0400000F RID: 15
		internal const string DigitalSignatureNamespace = "http://www.w3.org/2000/09/xmldsig#";

		// Token: 0x04000010 RID: 16
		internal const string Saml2ProtocolNamespace = "urn:oasis:names:tc:SAML:2.0:protocol";

		// Token: 0x04000011 RID: 17
		internal const string Saml2AssertionNamespace = "urn:oasis:names:tc:SAML:2.0:assertion";

		// Token: 0x04000012 RID: 18
		internal const string Saml2MessageVersion = "2.0";

		// Token: 0x04000013 RID: 19
		internal const string ServicesHttpMethodGet = "GET";

		// Token: 0x04000014 RID: 20
		internal const string ServicesHttpMethodPost = "POST";

		// Token: 0x04000015 RID: 21
		internal const string ServicesHttpParamRequest = "SAMLRequest";

		// Token: 0x04000016 RID: 22
		internal const string ServicesHttpParamResponse = "SAMLResponse";

		// Token: 0x04000017 RID: 23
		internal const string ServicesHttpRedirectParamSigAlg = "SigAlg";

		// Token: 0x04000018 RID: 24
		internal const string ServicesHttpRedirectParamSignature = "Signature";

		// Token: 0x04000019 RID: 25
		internal const string ServicesHttpRedirectRsaSha1 = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

		// Token: 0x0400001A RID: 26
		internal const string ServicesPostFormDest = "{samlDestination}";

		// Token: 0x0400001B RID: 27
		internal const string ServicesPostFormMessageType = "{samlMessageType}";

		// Token: 0x0400001C RID: 28
		internal const string ServicesPostFormMessage = "{samlMessage}";

		// Token: 0x0400001D RID: 29
		internal const string ServicesXpathSaml2NsPrefix = "zyxq987";

		// Token: 0x0400001E RID: 30
		internal const string ServicesXpathSaml2AssertionNsPrefix = "zyxq987asser";

		// Token: 0x0400001F RID: 31
		internal const string ServicesXpathDsigNsPrefix = "zyxq987dsig";

		// Token: 0x04000020 RID: 32
		internal const string ServicesXpathAssertion = "/zyxq987:Response/zyxq987asser:Assertion[1]";

		// Token: 0x04000021 RID: 33
		internal const string ServicesXpathEncryptedData = "/zyxq987:Response/zyxq987asser:EncryptedAssertion[1]/node()[local-name()='EncryptedData']";

		// Token: 0x04000022 RID: 34
		internal const string ServicesXpathSignature = "/*/zyxq987dsig:Signature[1]";

		// Token: 0x04000023 RID: 35
		internal const string ServicesDsigHashAlgSHA = "SHA";

		// Token: 0x04000024 RID: 36
		internal const string ServicesDsigSignatureElem = "Signature";

		// Token: 0x04000025 RID: 37
		internal const string ServicesDsigSignedInfoElem = "SignedInfo";

		// Token: 0x04000026 RID: 38
		internal const string ServicesDsigReferenceElem = "Reference";

		// Token: 0x04000027 RID: 39
		internal const string ServicesDsigAttrURI = "URI";

		// Token: 0x04000028 RID: 40
		internal const string ServicesDsigAttrID = "ID";

		// Token: 0x04000029 RID: 41
		internal const string ServicesDateTimeFormat = "yyyy.MM.dd HH:mm:ss.fff UTC";

		// Token: 0x0400002A RID: 42
		internal const string StoreReturnUrlKey = "RequestedUrl";

		// Token: 0x0400002B RID: 43
		internal const string StoreSessionIndexKey = "SessionIndex";

		// Token: 0x0400002C RID: 44
		internal const string StoreAuthControllerSessionIndexKey = "AuthenticationControllerSessionIndex";

		// Token: 0x0400002D RID: 45
		internal const string StorePrincipalSessionInfo = "PrincipalSessionInfo";

		// Token: 0x0400002E RID: 46
		internal const string StoreAuthRetried = "AuthRetried";

		// Token: 0x0400002F RID: 47
		internal const string AssertionAttributeRolesDefault = "Role";

		// Token: 0x04000030 RID: 48
		internal const string AssertionAttributeUsernameDefault = "Actor.Username";

		// Token: 0x04000031 RID: 49
		internal const string RegexRoleGroup = "<role>";

		// Token: 0x04000032 RID: 50
		internal const string RegexRoleGroupName = "role";

		// Token: 0x04000033 RID: 51
		internal const string RegexRoleGroupConfig = "{role}";

		// Token: 0x04000034 RID: 52
		internal const string FormsAuthReturnUrlParam = "ReturnUrl";

		// Token: 0x04000035 RID: 53
		internal const string TicketUserDataTag = "[Saml2Principal]";

		// Token: 0x04000036 RID: 54
		internal const string HttpPrefix = "http://";

		// Token: 0x04000037 RID: 55
		internal const string HttpsPrefix = "https://";

		// Token: 0x04000038 RID: 56
		internal const string SessionKeyPrefix = "Saml2Handler.UserDataSessionStore";
	}
}
