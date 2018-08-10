using System;
using System.Collections.Specialized;
using System.Security.Principal;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000AC RID: 172
	public interface IHttpContext
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004BC RID: 1212
		string RequestUrlAbsoluteUri { get; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004BD RID: 1213
		string RequestHttpMethod { get; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004BE RID: 1214
		NameValueCollection RequestQueryParams { get; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004BF RID: 1215
		NameValueCollection RequestPostParams { get; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060004C0 RID: 1216
		string RequestRootRelativePath { get; }

		// Token: 0x060004C1 RID: 1217
		string RequestGetCookie(string name);

		// Token: 0x060004C2 RID: 1218
		void ResponseWrite(string response);

		// Token: 0x060004C3 RID: 1219
		void ResponseRedirect(string url);

		// Token: 0x060004C4 RID: 1220
		void ResponseAddCookie(string name, string path, string value, bool https);

		// Token: 0x060004C5 RID: 1221
		void ResponseRedirectToLoginPage();

		// Token: 0x060004C6 RID: 1222
		void SessionSet(string key, object value);

		// Token: 0x060004C7 RID: 1223
		object SessionGet(string key);

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060004C8 RID: 1224
		string FormsAuthDefaultUrl { get; }

		// Token: 0x060004C9 RID: 1225
		void FormsAuthIssueTicket(DateTime now, string userName, string userData);

		// Token: 0x060004CA RID: 1226
		string FormsAuthGetTicketUserData();

		// Token: 0x060004CB RID: 1227
		void FormsAuthSignOut();

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060004CC RID: 1228
		string ApplicationPath { get; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004CD RID: 1229
		// (set) Token: 0x060004CE RID: 1230
		IPrincipal ApplicationCurrentUser { get; set; }

		// Token: 0x060004CF RID: 1231
		string ApplicationUrlEncode(string url);

		// Token: 0x060004D0 RID: 1232
		string ApplicationUrlDecode(string url);
	}
}
