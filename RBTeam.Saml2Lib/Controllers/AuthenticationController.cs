using System;
using System.Security.Principal;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Data.Model.Principal;
using RBTeam.Saml2Lib.Logger;
using RBTeam.Saml2Lib.Services;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Controllers
{
	// Token: 0x020000B8 RID: 184
	public class AuthenticationController
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x0000860F File Offset: 0x0000680F
		public AuthenticationController(ILog log)
		{
			this.logger = log;
			this.store = new UserDataSessionStore();
			this.principalService = new PrincipalService();
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00008634 File Offset: 0x00006834
		public void SignIn(Saml2Config config, Saml2ServiceProviderController samlController)
		{
			this.SignIn(config, samlController, AuthControllerUtility.GetReturnUrl(config.HttpContext));
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000864C File Offset: 0x0000684C
		public void SignIn(Saml2Config config, Saml2ServiceProviderController samlController, string returnUrl)
		{
			this.logger.Trace("Saml2Module.AuthenticationController load store", Array.Empty<object>());
			this.store.Load(config);
			this.store.Set(config, "RequestedUrl", returnUrl);
			samlController.SingIn(config, this.store);
			this.store.Store(config);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000086A5 File Offset: 0x000068A5
		public void CheckSignIn(Saml2Config config, Saml2ServiceProviderController samlController)
		{
			this.CheckSignIn(config, samlController, AuthControllerUtility.GetReturnUrl(config.HttpContext));
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000086BA File Offset: 0x000068BA
		public void CheckSignIn(Saml2Config config, Saml2ServiceProviderController samlController, string returnUrl)
		{
			this.store.Load(config);
			this.store.Set(config, "RequestedUrl", returnUrl);
			samlController.CheckSignIn(config, this.store);
			this.store.Store(config);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000086F4 File Offset: 0x000068F4
		public void RenewSignIn(Saml2Config config, Saml2ServiceProviderController samlController)
		{
			this.store.Load(config);
			this.store.Set(config, "RequestedUrl", config.SamlRefreshUrl);
			this.store.Set(config, "AuthRetried", true.ToString());
			samlController.RenewSignIn(config, this.store);
			this.store.Store(config);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00008758 File Offset: 0x00006958
		public bool RetrySignIn(Saml2Config config, Saml2ServiceProviderController samlController)
		{
			this.store.Load(config);
			if (this.store.Get<string>(config, "AuthRetried") == true.ToString())
			{
				return false;
			}
			this.store.Set(config, "AuthRetried", true.ToString());
			samlController.SingIn(config, this.store);
			this.store.Store(config);
			return true;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000087C8 File Offset: 0x000069C8
		public void SignOut(Saml2Config config, Saml2ServiceProviderController samlController, string returnUrl)
		{
			this.store.Load(config);
			this.store.Set(config, "RequestedUrl", returnUrl);
			samlController.SingOut(config, this.store);
			this.store.Store(config);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00008804 File Offset: 0x00006A04
		public void LocalLogout(Saml2Config config, bool redirectToLoginPage)
		{
			this.store.Load(config);
			string text = this.store.Get<string>(config, "SessionIndex");
			if (!string.IsNullOrEmpty(text))
			{
				this.store.Clear("SessionIndex");
				this.store.Clear(text);
				this.store.Store(config);
				config.HttpContext.SessionSet("AuthenticationControllerSessionIndex", string.Empty);
			}
			this.principalService.DeletePrincipal(config.HttpContext);
			if (redirectToLoginPage)
			{
				config.HttpContext.ResponseRedirectToLoginPage();
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00008894 File Offset: 0x00006A94
		public ISaml2Message ConsumeSamlMessage(Saml2Config config)
		{
			this.store.Load(config);
			ISaml2Message saml2Message = new Saml2ServiceProviderController(this.logger).ProcessIncommingMessage(config, this.store);
			StatusResponseType statusResponseType = saml2Message as StatusResponseType;
			if (statusResponseType != null)
			{
				if (MessageUtility.HasNoPassiveStatusCode(statusResponseType))
				{
					AuthenticationController.RedirectToReturnUrl(config, this.store);
					return saml2Message;
				}
				ResponseType responseType = statusResponseType as ResponseType;
				if (((responseType != null) ? responseType.Assertion : null) != null)
				{
					IPrincipal applicationCurrentUser = this.principalService.CreatePrincipal(responseType.Assertion, responseType.AssertionRaw, config.AssertionAttributes);
					config.HttpContext.ApplicationCurrentUser = applicationCurrentUser;
					this.store.Clear("AuthRetried");
					string value = this.store.Get<string>(config, "SessionIndex");
					config.HttpContext.SessionSet("AuthenticationControllerSessionIndex", value);
					AuthenticationController.RedirectToReturnUrl(config, this.store);
				}
				if (statusResponseType is LogoutResponseType)
				{
					AuthenticationController.RedirectToReturnUrl(config, this.store);
				}
			}
			this.store.Store(config);
			return saml2Message;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000898C File Offset: 0x00006B8C
		public void StoreCurrentUser(Saml2Config config)
		{
			Saml2Principal saml2Principal = config.HttpContext.ApplicationCurrentUser as Saml2Principal;
			if (saml2Principal == null || !saml2Principal.IsFromAssertion)
			{
				return;
			}
			this.principalService.StorePrincipal(config.HttpContext, config.GlobalContext, saml2Principal);
			this.store.Load(config);
			string sessionIndex = this.store.Get<string>(config, "SessionIndex");
			this.store.Set(config, sessionIndex, "PrincipalSessionInfo", config.GlobalContext.Serializer.Serialize(saml2Principal.SessionInfo));
			this.store.Store(config);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00008A20 File Offset: 0x00006C20
		public void ReconstructCurrentUser(Saml2Config config)
		{
			IPrincipal applicationCurrentUser = config.HttpContext.ApplicationCurrentUser;
			if (applicationCurrentUser == null || !applicationCurrentUser.Identity.IsAuthenticated)
			{
				return;
			}
			string text = config.HttpContext.FormsAuthGetTicketUserData();
			if (text == null || !text.StartsWith("[Saml2Principal]"))
			{
				return;
			}
			text = text.Substring("[Saml2Principal]".Length);
			Saml2Principal saml2Principal = new PrincipalService().LoadPrincipal(config.GlobalContext.Serializer, text);
			if (saml2Principal == null)
			{
				return;
			}
			saml2Principal.SessionInfoLoader = (() => this.LoadCurrentUserSessionInfo(config));
			config.HttpContext.ApplicationCurrentUser = saml2Principal;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00008ADC File Offset: 0x00006CDC
		internal PrincipalSessionInfo LoadCurrentUserSessionInfo(Saml2Config config)
		{
			if (!(config.HttpContext.ApplicationCurrentUser is Saml2Principal))
			{
				return null;
			}
			this.store.Load(config);
			string text = this.store.Get<string>(config, "SessionIndex");
			if (string.IsNullOrEmpty(text))
			{
				return new PrincipalSessionInfo();
			}
			string str = this.store.Get<string>(config, text, "PrincipalSessionInfo");
			return config.GlobalContext.Serializer.Deserialize<PrincipalSessionInfo>(str);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00008B50 File Offset: 0x00006D50
		public bool VerifyUserSession(Saml2Config config)
		{
			Saml2Principal saml2Principal = config.HttpContext.ApplicationCurrentUser as Saml2Principal;
			if (saml2Principal == null)
			{
				return true;
			}
			string sessionIndex = saml2Principal.TicketInfo.SessionIndex;
			string b = (string)config.HttpContext.SessionGet("AuthenticationControllerSessionIndex");
			return sessionIndex == b;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00008B9C File Offset: 0x00006D9C
		public bool ReloadToken(Saml2Config config)
		{
			Saml2Principal saml2Principal = config.HttpContext.ApplicationCurrentUser as Saml2Principal;
			return saml2Principal != null && (saml2Principal.TicketInfo.ValidTo - DateTime.UtcNow).TotalSeconds <= 0.0;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00008BEC File Offset: 0x00006DEC
		public bool RenewSessionToken(Saml2Config config)
		{
			if (!config.HttpContext.RequestRootRelativePath.Equals(config.SamlRefreshUrl))
			{
				return false;
			}
			Saml2Principal saml2Principal = config.HttpContext.ApplicationCurrentUser as Saml2Principal;
			return saml2Principal != null && (saml2Principal.TicketInfo.ValidTo - DateTime.UtcNow).TotalSeconds - (double)config.SessionExpirationOffset <= 0.0;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00008C5C File Offset: 0x00006E5C
		private static void RedirectToReturnUrl(Saml2Config config, UserDataStoreBase store)
		{
			string text = store.Get<string>(config, "RequestedUrl");
			if (!string.IsNullOrEmpty(text))
			{
				config.HttpContext.ResponseRedirect(text);
			}
		}

		// Token: 0x0400021D RID: 541
		private readonly UserDataSessionStore store;

		// Token: 0x0400021E RID: 542
		private readonly PrincipalService principalService;

		// Token: 0x0400021F RID: 543
		private readonly ILog logger;
	}
}
