using System;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Services;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x02000010 RID: 16
	internal static class Saml2ControllerUtility
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00003553 File Offset: 0x00001753
		internal static string GetStoredAuthnRequestIDKey(string id)
		{
			return Saml2MessageTypeEnum.AuthnRequest + id;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003553 File Offset: 0x00001753
		internal static string GetStoredLogoutRequestIDKey(string id)
		{
			return Saml2MessageTypeEnum.AuthnRequest + id;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003561 File Offset: 0x00001761
		internal static string GetSessionIndexFromStore(Saml2Config config, UserDataStoreBase store)
		{
			return store.Get<string>(config, "SessionIndex");
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003570 File Offset: 0x00001770
		internal static NameIDType GetTicketNameID(Saml2Config config)
		{
			ISaml2Principal saml2Principal = config.HttpContext.ApplicationCurrentUser as ISaml2Principal;
			if (saml2Principal != null)
			{
				return new NameIDType
				{
					Value = saml2Principal.NameID,
					Format = saml2Principal.NameIDFormat,
					NameQualifier = saml2Principal.NameIDIdp,
					SPNameQualifier = saml2Principal.NameIDSp
				};
			}
			return null;
		}
	}
}
