using System;
using RBTeam.Saml2Lib.Data.Infra;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x02000007 RID: 7
	internal static class AuthControllerUtility
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002ABC File Offset: 0x00000CBC
		internal static string GetReturnUrl(IHttpContext httpContext)
		{
			string text = httpContext.RequestQueryParams["ReturnUrl"];
			if (string.IsNullOrEmpty(text))
			{
				return text ?? httpContext.FormsAuthDefaultUrl;
			}
			string result;
			try
			{
				result = new Uri(text, UriKind.Relative).AbsoluteUri;
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}
