using System;
using System.Collections.Generic;
using System.Security.Principal;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Data.Model.Principal;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x02000013 RID: 19
	internal class PrincipalService
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00003860 File Offset: 0x00001A60
		internal IPrincipal CreatePrincipal(AssertionType assertion, string assertionRaw, AssertionAttributesConfig attrConfig)
		{
			assertion.Attributes.MapAttributeValues(attrConfig);
			List<string> multiValue = assertion.Attributes.GetMultiValue(attrConfig.RolesAttribute);
			PrincipalTicketInfo principalTicketInfo = new PrincipalTicketInfo();
			principalTicketInfo.Username = PrincipalService.GetUserNameOrNameID(assertion, attrConfig);
			principalTicketInfo.AuthnType = assertion.AuthnContextClassRef;
			principalTicketInfo.SessionIndex = assertion.AuthnStatement.SessionIndex;
			principalTicketInfo.Id = assertion.Subject.NameID.Value;
			principalTicketInfo.IdFormat = assertion.Subject.NameID.Format;
			principalTicketInfo.IdIdp = assertion.Subject.NameID.NameQualifier;
			principalTicketInfo.IdSp = assertion.Subject.NameID.SPNameQualifier;
			principalTicketInfo.ValidTo = assertion.AuthnStatement.SessionNotOnOrAfter;
			PrincipalSessionInfo sessionInfo = new PrincipalSessionInfo
			{
				Assertion = assertionRaw,
				Attributes = this.CreateAttributeDictionary(assertion),
				Roles = multiValue
			};
			PrincipalCookieInfo cookieInfo = new PrincipalCookieInfo
			{
				Roles = multiValue
			};
			return new Saml2Principal(principalTicketInfo, cookieInfo, sessionInfo, true);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000395C File Offset: 0x00001B5C
		internal void StorePrincipal(IHttpContext httpContext, IGlobalContext globalContext, Saml2Principal principal)
		{
			string userData = "[Saml2Principal]" + globalContext.Serializer.Serialize(principal.TicketInfo);
			httpContext.FormsAuthIssueTicket(globalContext.DateTimeNow, principal.Identity.Name, userData);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000039A0 File Offset: 0x00001BA0
		internal Saml2Principal LoadPrincipal(ISerializer serializer, string principalTicketInfoSerialized)
		{
			Saml2Principal result;
			try
			{
				PrincipalTicketInfo ticketInfo = serializer.Deserialize<PrincipalTicketInfo>(principalTicketInfoSerialized);
				PrincipalCookieInfo cookieInfo = new PrincipalCookieInfo
				{
					Roles = new List<string>()
				};
				new PrincipalSessionInfo().Attributes = new Dictionary<string, List<string>>();
				result = new Saml2Principal(ticketInfo, cookieInfo);
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("unable to restore Saml2Principal", innerException);
			}
			return result;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003A00 File Offset: 0x00001C00
		internal void DeletePrincipal(IHttpContext httpContext)
		{
			httpContext.FormsAuthSignOut();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003A08 File Offset: 0x00001C08
		private Dictionary<string, List<string>> CreateAttributeDictionary(AssertionType assertion)
		{
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			foreach (string text in assertion.Attributes.GetAttributeNames())
			{
				List<string> multiValue = assertion.Attributes.GetMultiValue(text);
				dictionary.Add(text, multiValue);
			}
			return dictionary;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003A70 File Offset: 0x00001C70
		private static string GetUserNameOrNameID(AssertionType assertion, AssertionAttributesConfig attrConfig)
		{
			string value = assertion.Attributes.GetValue(attrConfig.UserNameAttribute);
			if (string.IsNullOrEmpty(value))
			{
				value = assertion.Subject.NameID.Value;
			}
			return value;
		}
	}
}
