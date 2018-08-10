using System;
using System.Web;
using System.Web.SessionState;

namespace RBTeam.Saml2Lib
{
	// Token: 0x02000003 RID: 3
	public class Saml2Handler : IHttpHandler, IRequiresSessionState
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002814 File Offset: 0x00000A14
		public bool IsReusable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002817 File Offset: 0x00000A17
		public void ProcessRequest(HttpContext context)
		{
			Saml2Module.Instance.ProcessMessage();
		}
	}
}
