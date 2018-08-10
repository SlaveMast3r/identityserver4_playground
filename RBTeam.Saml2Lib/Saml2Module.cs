using System;
using System.Configuration;
using System.Web;
using System.Web.SessionState;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Controllers;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Events;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Logger;
using RBTeam.Saml2Lib.Web;

namespace RBTeam.Saml2Lib
{
	// Token: 0x02000002 RID: 2
	public class Saml2Module : IHttpModule, IRequiresSessionState
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Saml2Module()
		{
			//this.logger = new Log();
			Saml2Module.instance = this;
			this.saml2Controller = new Saml2ServiceProviderController(this.logger);
			this.saml2Controller.MessageCreated += delegate(object sender, Saml2MessageEventArgs args)
			{
				this.FireBeforeSignIn(args);
			};
			this.authController = new AuthenticationController(this.logger);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020AD File Offset: 0x000002AD
		public void Init(HttpApplication context)
		{
			this.httpApplication = context;
			this.httpApplication.PostAuthenticateRequest += this.PostAuthenticateRequest;
			this.httpApplication.PostAcquireRequestState += this.PostAcquireRequestState;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E4 File Offset: 0x000002E4
		public void SignIn()
		{
			this.logger.Trace("Saml2Module.SignIn", Array.Empty<object>());
			this.HandleError(delegate
			{
				this.authController.SignIn(this.Config, this.saml2Controller);
			}, null);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002110 File Offset: 0x00000310
		public void SignIn(string returnUrl)
		{
			this.logger.Trace("Saml2Module.SignIn", Array.Empty<object>());
			this.HandleError(delegate
			{
				this.authController.SignIn(this.Config, this.saml2Controller, returnUrl);
			}, null);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002159 File Offset: 0x00000359
		public void RenewSignIn()
		{
			this.logger.Trace("Saml2Module.RenewSignIn", Array.Empty<object>());
			this.HandleError(delegate
			{
				this.authController.RenewSignIn(this.Config, this.saml2Controller);
			}, null);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002183 File Offset: 0x00000383
		public void CheckSignIn()
		{
			this.logger.Trace("Saml2Module.CheckSignIn", Array.Empty<object>());
			this.HandleError(delegate
			{
				this.authController.CheckSignIn(this.Config, this.saml2Controller);
			}, null);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021B0 File Offset: 0x000003B0
		public void CheckSignIn(string returnUrl)
		{
			this.logger.Trace("Saml2Module.CheckSignIn rurl={0}", new object[]
			{
				returnUrl
			});
			this.HandleError(delegate
			{
				this.authController.CheckSignIn(this.Config, this.saml2Controller, returnUrl);
			}, null);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002204 File Offset: 0x00000404
		public void SignOut(string returnUrl)
		{
			this.logger.Trace("Saml2Module.SignOut rurl={0}", new object[]
			{
				returnUrl
			});
			this.HandleError(delegate
			{
				this.authController.SignOut(this.Config, this.saml2Controller, returnUrl);
			}, null);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002258 File Offset: 0x00000458
		public void SignOut(string returnUrl, ISaml2Principal principal)
		{
			this.logger.Trace("Saml2Module.SignOut rurl={0}", new object[]
			{
				returnUrl
			});
			this.Config.HttpContext.ApplicationCurrentUser = principal;
			this.HandleError(delegate
			{
				this.authController.SignOut(this.Config, this.saml2Controller, returnUrl);
			}, null);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022BC File Offset: 0x000004BC
		public void LocalLogout(bool redirectToLoginPage)
		{
			this.logger.Trace("Saml2Module.LocalLogout return={0}", new object[]
			{
				redirectToLoginPage
			});
			this.HandleError(delegate
			{
				this.authController.LocalLogout(this.config, redirectToLoginPage);
				this.FireSignedOut();
			}, null);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002314 File Offset: 0x00000514
		private void PostAuthenticateRequest(object sender, EventArgs e)
		{
			this.authController.ReconstructCurrentUser(this.Config);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002328 File Offset: 0x00000528
		private void PostAcquireRequestState(object sender, EventArgs e)
		{
			if (!(HttpContext.Current.Handler is IRequiresSessionState))
			{
				return;
			}
			if (!this.authController.VerifyUserSession(this.Config))
			{
				this.LocalLogout(true);
			}
			if (this.authController.ReloadToken(this.config))
			{
				this.LocalLogout(false);
				this.SignIn();
			}
			if (this.authController.RenewSessionToken(this.config))
			{
				this.RenewSignIn();
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000239A File Offset: 0x0000059A
		public static Saml2Module Instance
		{
			get
			{
				if (Saml2Module.instance == null)
				{
					throw new NullReferenceException("Saml2Module is not initialized");
				}
				return Saml2Module.instance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000023B4 File Offset: 0x000005B4
		public Saml2Config Config
		{
			get
			{
				if (this.config != null)
				{
					return this.config;
				}
				this.HandleError(delegate
				{
					this.config = (Saml2Config)ConfigurationManager.GetSection("saml2Config");
				}, null);
				if (this.config == null)
				{
					this.logger.Fatal("saml2Config is not found in config file");
					throw new NullReferenceException("saml2Config is not found in config file");
				}
				this.config.GlobalContext = new GlobalContext();
				this.config.HttpContext = new GlobalHttpContext();
				return this.config;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000242C File Offset: 0x0000062C
		public void Dispose()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002430 File Offset: 0x00000630
		public void ProcessMessage()
		{
			bool isLogout = false;
			this.HandleError(delegate
			{
				ISaml2Message saml2Message = this.authController.ConsumeSamlMessage(this.Config);
				ISaml2ResponseMessage saml2ResponseMessage = saml2Message as ISaml2ResponseMessage;
				if (saml2ResponseMessage != null && saml2ResponseMessage.StatusCode == "urn:oasis:names:tc:SAML:2.0:status:Requester" && saml2ResponseMessage.SecondLevelStatusCode == "urn:oasis:names:tc:SAML:2.0:status:NoPassive")
				{
					this.FireAnonymousSignInAttempt();
					return;
				}
				if (saml2Message is ResponseType)
				{
					this.authController.StoreCurrentUser(this.Config);
					this.FireSignedIn();
				}
				if (saml2Message is LogoutRequestType || saml2Message is LogoutResponseType)
				{
					isLogout = true;
				}
			}, delegate
			{
				if (isLogout)
				{
					this.LocalLogout(false);
				}
			});
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000011 RID: 17 RVA: 0x00002470 File Offset: 0x00000670
		// (remove) Token: 0x06000012 RID: 18 RVA: 0x000024A8 File Offset: 0x000006A8
		public event Saml2MessageEventHandler BeforeSignIn;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000013 RID: 19 RVA: 0x000024E0 File Offset: 0x000006E0
		// (remove) Token: 0x06000014 RID: 20 RVA: 0x00002518 File Offset: 0x00000718
		public event Saml2EventHandler SignedIn;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000015 RID: 21 RVA: 0x00002550 File Offset: 0x00000750
		// (remove) Token: 0x06000016 RID: 22 RVA: 0x00002588 File Offset: 0x00000788
		public event Saml2EventHandler AnonymousSignInAttempt;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000017 RID: 23 RVA: 0x000025C0 File Offset: 0x000007C0
		// (remove) Token: 0x06000018 RID: 24 RVA: 0x000025F8 File Offset: 0x000007F8
		public event Saml2EventHandler SignedOut;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000019 RID: 25 RVA: 0x00002630 File Offset: 0x00000830
		// (remove) Token: 0x0600001A RID: 26 RVA: 0x00002668 File Offset: 0x00000868
		public event Saml2ErrorEventHandler Error;

		// Token: 0x0600001B RID: 27 RVA: 0x000026A0 File Offset: 0x000008A0
		private void HandleError(Action action, Action postAction = null)
		{
			Exception ex = null;
			try
			{
				action();
			}
			catch (Exception ex2)
			{
				this.logger.Error(ex2, "Saml2Module.HandleError");
				if (ex2 is ResponseNotSuccessException && this.authController.RetrySignIn(this.Config, this.saml2Controller))
				{
					return;
				}
				ex = ex2;
			}
			if (postAction != null)
			{
				postAction();
			}
			if (ex != null)
			{
				this.FireError(ex);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002714 File Offset: 0x00000914
		private void FireError(Exception e)
		{
			if (this.Error != null)
			{
				this.Error(this, new Saml2ErrorEventArgs(e));
				return;
			}
			this.logger.Fatal(e, "Saml2Module.Error");
			throw new Saml2ModuleUnhandledException("Saml2Module.Error event", e);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000274D File Offset: 0x0000094D
		private void FireBeforeSignIn(Saml2MessageEventArgs args)
		{
			Saml2MessageEventHandler beforeSignIn = this.BeforeSignIn;
			if (beforeSignIn == null)
			{
				return;
			}
			beforeSignIn(this, args);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002761 File Offset: 0x00000961
		private void FireSignedOut()
		{
			Saml2EventHandler signedOut = this.SignedOut;
			if (signedOut == null)
			{
				return;
			}
			signedOut(this, new EventArgs());
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002779 File Offset: 0x00000979
		private void FireAnonymousSignInAttempt()
		{
			Saml2EventHandler anonymousSignInAttempt = this.AnonymousSignInAttempt;
			if (anonymousSignInAttempt == null)
			{
				return;
			}
			anonymousSignInAttempt(this, new EventArgs());
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002791 File Offset: 0x00000991
		private void FireSignedIn()
		{
			Saml2EventHandler signedIn = this.SignedIn;
			if (signedIn == null)
			{
				return;
			}
			signedIn(this, new EventArgs());
		}

		// Token: 0x04000001 RID: 1
		private static Saml2Module instance;

		// Token: 0x04000002 RID: 2
		private HttpApplication httpApplication;

		// Token: 0x04000003 RID: 3
		private Saml2Config config;

		// Token: 0x04000004 RID: 4
		private readonly Saml2ServiceProviderController saml2Controller;

		// Token: 0x04000005 RID: 5
		private readonly AuthenticationController authController;

		// Token: 0x04000006 RID: 6
		private readonly ILog logger;
	}
}
