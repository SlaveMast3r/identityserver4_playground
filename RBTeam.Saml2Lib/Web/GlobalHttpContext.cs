using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using RBTeam.Saml2Lib.Data.Infra;

namespace RBTeam.Saml2Lib.Web
{
	// Token: 0x02000005 RID: 5
	public class GlobalHttpContext : IHttpContext
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002861 File Offset: 0x00000A61
		public string RequestUrlAbsoluteUri
		{
			get
			{
				return HttpContext.Current.Request.Url.AbsoluteUri;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002877 File Offset: 0x00000A77
		public string RequestHttpMethod
		{
			get
			{
				return HttpContext.Current.Request.HttpMethod;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002888 File Offset: 0x00000A88
		public NameValueCollection RequestQueryParams
		{
			get
			{
				return HttpContext.Current.Request.QueryString;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002899 File Offset: 0x00000A99
		public NameValueCollection RequestPostParams
		{
			get
			{
				return HttpContext.Current.Request.Form;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000028AA File Offset: 0x00000AAA
		public string RequestRootRelativePath
		{
			get
			{
				return HttpContext.Current.Request.AppRelativeCurrentExecutionFilePath;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000028BB File Offset: 0x00000ABB
		public string RequestGetCookie(string name)
		{
			HttpCookie httpCookie = HttpContext.Current.Request.Cookies[name];
			if (httpCookie == null)
			{
				return null;
			}
			return httpCookie.Value;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000028DD File Offset: 0x00000ADD
		public void ResponseWrite(string response)
		{
			HttpContext.Current.Response.Write(response);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000028EF File Offset: 0x00000AEF
		public void ResponseRedirect(string url)
		{
			HttpContext.Current.Response.Redirect(url, false);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002904 File Offset: 0x00000B04
		public void ResponseAddCookie(string name, string path, string value, bool https)
		{
			HttpCookie httpCookie = new HttpCookie(name, value);
			if (!string.IsNullOrEmpty(path))
			{
				httpCookie.Path = path;
			}
			httpCookie.Secure = https;
			HttpContext.Current.Response.Cookies.Add(httpCookie);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002945 File Offset: 0x00000B45
		public void ResponseRedirectToLoginPage()
		{
			FormsAuthentication.RedirectToLoginPage();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000294C File Offset: 0x00000B4C
		public void SessionSet(string key, object value)
		{
			HttpContext.Current.Session.Add(key, value);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000295F File Offset: 0x00000B5F
		public object SessionGet(string key)
		{
			return HttpContext.Current.Session[key];
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002971 File Offset: 0x00000B71
		public string FormsAuthDefaultUrl
		{
			get
			{
				return FormsAuthentication.DefaultUrl;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002978 File Offset: 0x00000B78
		public void FormsAuthIssueTicket(DateTime now, string userName, string userData)
		{
			if (this.formsAuthTimeout == null)
			{
				AuthenticationSection authenticationSection = (AuthenticationSection)ConfigurationManager.GetSection("system.web/authentication");
				this.formsAuthTimeout = new TimeSpan?(authenticationSection.Forms.Timeout);
			}
			string value = FormsAuthentication.Encrypt(new FormsAuthenticationTicket(1, userName, now, now + this.formsAuthTimeout.Value, false, userData));
			if (string.IsNullOrEmpty(value))
			{
				throw new NullReferenceException("Forms authentication ticket creation failed: " + FormsAuthentication.FormsCookieName);
			}
			this.ResponseAddCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.FormsCookiePath, value, FormsAuthentication.RequireSSL);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A0C File Offset: 0x00000C0C
		public string FormsAuthGetTicketUserData()
		{
			FormsAuthenticationTicket formsAuthenticationTicket = FormsAuthentication.Decrypt(this.RequestGetCookie(FormsAuthentication.FormsCookieName));
			if (formsAuthenticationTicket != null)
			{
				return formsAuthenticationTicket.UserData;
			}
			return "";
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A39 File Offset: 0x00000C39
		public void FormsAuthSignOut()
		{
			FormsAuthentication.SignOut();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002A40 File Offset: 0x00000C40
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002A4C File Offset: 0x00000C4C
		public IPrincipal ApplicationCurrentUser
		{
			get
			{
				return HttpContext.Current.User;
			}
			set
			{
				HttpContext.Current.User = value;
				Thread.CurrentPrincipal = value;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002A5F File Offset: 0x00000C5F
		public string ApplicationUrlEncode(string url)
		{
			return HttpContext.Current.Server.UrlEncode(url);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002A71 File Offset: 0x00000C71
		public string ApplicationUrlDecode(string url)
		{
			return HttpContext.Current.Server.UrlDecode(url);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002A83 File Offset: 0x00000C83
		public string ApplicationPath
		{
			get
			{
				return HttpRuntime.AppDomainAppPath;
			}
		}

		// Token: 0x0400000D RID: 13
		private TimeSpan? formsAuthTimeout;
	}
}
