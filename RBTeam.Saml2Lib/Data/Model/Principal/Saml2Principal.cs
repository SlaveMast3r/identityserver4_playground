using System;
using System.Collections.Generic;
using System.Security.Principal;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Data.Model.Principal
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	internal class Saml2Principal : GenericPrincipal, ISaml2Principal, IPrincipal
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00006865 File Offset: 0x00004A65
		internal Saml2Principal(PrincipalTicketInfo ticketInfo, PrincipalCookieInfo cookieInfo, PrincipalSessionInfo sessionInfo, bool isFromAssertion) : base(new Saml2Identity(ticketInfo, true), Saml2Principal.CheckCookieInfo(cookieInfo))
		{
			if (sessionInfo == null)
			{
				throw new Saml2ModuleException("sessionInfo");
			}
			this.TicketInfo = ticketInfo;
			this.CookieInfo = cookieInfo;
			this.SessionInfo = sessionInfo;
			this.IsFromAssertion = isFromAssertion;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000068A5 File Offset: 0x00004AA5
		internal Saml2Principal(PrincipalTicketInfo ticketInfo, PrincipalCookieInfo cookieInfo) : base(new Saml2Identity(ticketInfo, true), Saml2Principal.CheckCookieInfo(cookieInfo))
		{
			this.TicketInfo = ticketInfo;
			this.CookieInfo = cookieInfo;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000068C8 File Offset: 0x00004AC8
		private static string[] CheckCookieInfo(PrincipalCookieInfo cookieInfo)
		{
			if (cookieInfo == null)
			{
				throw new Saml2ModuleException("cookieInfo");
			}
			return cookieInfo.Roles.ToArray();
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000068E3 File Offset: 0x00004AE3
		// (set) Token: 0x06000160 RID: 352 RVA: 0x000068EB File Offset: 0x00004AEB
		internal PrincipalTicketInfo TicketInfo { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000068F4 File Offset: 0x00004AF4
		// (set) Token: 0x06000162 RID: 354 RVA: 0x000068FC File Offset: 0x00004AFC
		internal PrincipalCookieInfo CookieInfo { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00006905 File Offset: 0x00004B05
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0000690D File Offset: 0x00004B0D
		internal Func<PrincipalSessionInfo> SessionInfoLoader
		{
			get
			{
				return this.sessionInfoLoader;
			}
			set
			{
				this.sessionInfoLoader = value;
				((Saml2Identity)this.Identity).SessionInfoLoader = (() => this.SessionInfo);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00006932 File Offset: 0x00004B32
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00006962 File Offset: 0x00004B62
		internal PrincipalSessionInfo SessionInfo
		{
			get
			{
				if (this.sessionInfo != null)
				{
					return this.sessionInfo;
				}
				if (this.SessionInfoLoader != null)
				{
					this.sessionInfo = this.SessionInfoLoader();
				}
				return this.sessionInfo;
			}
			set
			{
				this.sessionInfo = value;
				((Saml2Identity)this.Identity).SessionInfoLoader = (() => this.sessionInfo);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00006987 File Offset: 0x00004B87
		internal bool IsFromAssertion { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000698F File Offset: 0x00004B8F
		public string NameID
		{
			get
			{
				return this.TicketInfo.Id;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000699C File Offset: 0x00004B9C
		public string NameIDFormat
		{
			get
			{
				return this.TicketInfo.IdFormat;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000069A9 File Offset: 0x00004BA9
		public string NameIDIdp
		{
			get
			{
				return this.TicketInfo.IdIdp;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000069B6 File Offset: 0x00004BB6
		public string NameIDSp
		{
			get
			{
				return this.TicketInfo.IdSp;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000069C3 File Offset: 0x00004BC3
		public string SessionIndex
		{
			get
			{
				return this.TicketInfo.SessionIndex;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000069D0 File Offset: 0x00004BD0
		public new IDictionary<string, IEnumerable<string>> Claims
		{
			get
			{
				if (this.claims != null)
				{
					return this.claims;
				}
				this.claims = new Dictionary<string, IEnumerable<string>>();
				Dictionary<string, List<string>> attributes = this.SessionInfo.Attributes;
				foreach (string key in attributes.Keys)
				{
					this.claims.Add(key, attributes[key]);
				}
				return this.claims;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00006A5C File Offset: 0x00004C5C
		public string Assertion
		{
			get
			{
				return this.SessionInfo.Assertion;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00006A69 File Offset: 0x00004C69
		public IEnumerable<string> Roles
		{
			get
			{
				if (this.CookieInfo.Roles.Count <= 0)
				{
					return this.SessionInfo.Roles;
				}
				return this.CookieInfo.Roles;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00006A95 File Offset: 0x00004C95
		public IPrincipal Copy()
		{
			return new Saml2Principal(this.TicketInfo, this.CookieInfo)
			{
				SessionInfoLoader = this.SessionInfoLoader
			};
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00006AB4 File Offset: 0x00004CB4
		public new List<IIdentity> Identities
		{
			get
			{
				return new List<IIdentity>
				{
					this.Identity
				};
			}
		}

		// Token: 0x0400006D RID: 109
		private Func<PrincipalSessionInfo> sessionInfoLoader;

		// Token: 0x0400006E RID: 110
		private PrincipalSessionInfo sessionInfo;

		// Token: 0x04000070 RID: 112
		private IDictionary<string, IEnumerable<string>> claims;
	}
}
