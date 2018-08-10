using System;
using System.Text;
using RBTeam.Saml2Lib.Data.Infra;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x02000008 RID: 8
	internal static class BindingUtility
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002B14 File Offset: 0x00000D14
		internal static string GetRedirectQueryStringWithSignAlg(IHttpContext httpContext, string messageRaw, bool isResponse)
		{
			string redirectQueryString = BindingUtility.GetRedirectQueryString(httpContext, messageRaw, isResponse);
			string text = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
			text = httpContext.ApplicationUrlEncode(text);
			string str = "&SigAlg=" + text;
			return redirectQueryString + str;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002B49 File Offset: 0x00000D49
		internal static string GetRedirectQueryString(IHttpContext httpContext, string messageRaw, bool isResponse)
		{
			return BindingUtility.GetSaml2ParameterName(isResponse) + "=" + httpContext.ApplicationUrlEncode(Convert.ToBase64String(DeflateUtility.Zip(Encoding.UTF8.GetBytes(messageRaw))));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002B76 File Offset: 0x00000D76
		internal static string GetSaml2ParameterName(bool isResponse)
		{
			if (!isResponse)
			{
				return "SAMLRequest";
			}
			return "SAMLResponse";
		}
	}
}
