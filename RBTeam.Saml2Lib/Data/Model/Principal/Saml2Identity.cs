using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Principal;
using System.Xml;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Data.Model.Principal
{
	// Token: 0x02000035 RID: 53
	[Serializable]
	internal class Saml2Identity : GenericIdentity, ISaml2Identity, IIdentity
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00006657 File Offset: 0x00004857
		internal Saml2Identity(PrincipalTicketInfo ticketInfo, bool isAuthenticated) : base(Saml2Identity.CheckName(ticketInfo), ticketInfo.AuthnType)
		{
			this.ticketInfo = ticketInfo;
			this.IsAuthenticated = isAuthenticated;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00006679 File Offset: 0x00004879
		public override bool IsAuthenticated { get; }

		// Token: 0x0600014C RID: 332 RVA: 0x00006681 File Offset: 0x00004881
		private static string CheckName(PrincipalTicketInfo ticketInfo)
		{
			if (ticketInfo == null)
			{
				throw new Saml2ModuleException("ticketInfo");
			}
			return ticketInfo.Username;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00006698 File Offset: 0x00004898
		private PrincipalSessionInfo SessionInfo
		{
			get
			{
				PrincipalSessionInfo result;
				if ((result = this.sessionInfo) == null)
				{
					result = (this.sessionInfo = this.SessionInfoLoader());
				}
				return result;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000066C3 File Offset: 0x000048C3
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000066CB File Offset: 0x000048CB
		internal Func<PrincipalSessionInfo> SessionInfoLoader { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000066D4 File Offset: 0x000048D4
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000066DC File Offset: 0x000048DC
		public new IIdentity Actor { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000066E8 File Offset: 0x000048E8
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00006748 File Offset: 0x00004948
		public SecurityToken BootstrapToken
		{
			get
			{
				if (string.IsNullOrEmpty(this.SessionInfo.Assertion))
				{
					return null;
				}
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(this.SessionInfo.Assertion);
				return new GenericXmlSecurityToken(xmlDocument.DocumentElement, null, DateTime.Now, DateTime.Now.AddDays(1.0), null, null, null);
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00006750 File Offset: 0x00004950
		public new List<Claim> Claims
		{
			get
			{
				if (this.claims != null)
				{
					return this.claims;
				}
				this.claims = new List<Claim>();
				Dictionary<string, List<string>> attributes = this.SessionInfo.Attributes;
				foreach (string text in attributes.Keys)
				{
					foreach (string value in attributes[text])
					{
						this.claims.Add(new Claim(text, value));
					}
				}
				return this.claims;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006818 File Offset: 0x00004A18
		public IIdentity Copy()
		{
			return new Saml2Identity(this.ticketInfo, true)
			{
				SessionInfoLoader = this.SessionInfoLoader
			};
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00006832 File Offset: 0x00004A32
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000683A File Offset: 0x00004A3A
		public new string Label { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00006843 File Offset: 0x00004A43
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000684B File Offset: 0x00004A4B
		public new string NameClaimType { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00006854 File Offset: 0x00004A54
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000685C File Offset: 0x00004A5C
		public new string RoleClaimType { get; set; }

		// Token: 0x04000062 RID: 98
		private readonly PrincipalTicketInfo ticketInfo;

		// Token: 0x04000064 RID: 100
		private PrincipalSessionInfo sessionInfo;

		// Token: 0x04000067 RID: 103
		private List<Claim> claims;
	}
}
