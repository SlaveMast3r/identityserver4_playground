using System;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Events;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Logger;
using RBTeam.Saml2Lib.MessageProcessing;
using RBTeam.Saml2Lib.Services;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Controllers
{
	// Token: 0x020000B9 RID: 185
	public class Saml2ServiceProviderController
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00008C8A File Offset: 0x00006E8A
		internal Saml2ServiceProviderController(ILog log)
		{
			this.logger = log;
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000508 RID: 1288 RVA: 0x00008C9C File Offset: 0x00006E9C
		// (remove) Token: 0x06000509 RID: 1289 RVA: 0x00008CD4 File Offset: 0x00006ED4
		public event Saml2MessageEventHandler MessageCreated;

		// Token: 0x0600050A RID: 1290 RVA: 0x00008D0C File Offset: 0x00006F0C
		internal void SingIn(Saml2Config config, UserDataStoreBase store)
		{
			this.logger.Info("Saml2ServiceProviderController.SingIn");
			ISaml2Sender saml2Sender = Saml2Config.CreateSender(this.logger);
			saml2Sender.MessageCreated += delegate(ISaml2Message message)
			{
				Saml2MessageEventHandler messageCreated = this.MessageCreated;
				if (messageCreated == null)
				{
					return;
				}
				messageCreated(this, new Saml2MessageEventArgs(message));
			};
			ISaml2Message saml2Message = saml2Sender.SendMessage(Saml2MessageTypeEnum.AuthnRequest, "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect", config);
			store.SetExpirable(config, Saml2ControllerUtility.GetStoredAuthnRequestIDKey(saml2Message.ID), saml2Message.ID);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00008D6C File Offset: 0x00006F6C
		internal void RenewSignIn(Saml2Config config, UserDataStoreBase store)
		{
			this.logger.Info("Saml2ServiceProviderController.RenewSignIn");
			ISaml2Sender saml2Sender = Saml2Config.CreateSender(this.logger);
			saml2Sender.MessageCreated += delegate(ISaml2Message message)
			{
				if (this.MessageCreated == null)
				{
					return;
				}
				AuthnRequestType authnRequestType = message as AuthnRequestType;
				if (authnRequestType != null)
				{
					AuthnRequestType authnRequestType2 = authnRequestType;
					authnRequestType2.ForceAuthn = true;
					authnRequestType2.IsPassive = true;
					authnRequestType2.ForceAuthnSpecified = true;
					authnRequestType2.IsPassiveSpecified = true;
				}
				this.MessageCreated(this, new Saml2MessageEventArgs(message));
			};
			ISaml2Message saml2Message = saml2Sender.SendMessage(Saml2MessageTypeEnum.AuthnRequest, "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect", config);
			store.SetExpirable(config, Saml2ControllerUtility.GetStoredAuthnRequestIDKey(saml2Message.ID), saml2Message.ID);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00008DCC File Offset: 0x00006FCC
		internal void CheckSignIn(Saml2Config config, UserDataStoreBase store)
		{
			this.logger.Info("Saml2ServiceProviderController.CheckSignIn");
			ISaml2Sender saml2Sender = Saml2Config.CreateSender(this.logger);
			saml2Sender.MessageCreated += delegate(ISaml2Message message)
			{
				if (this.MessageCreated == null)
				{
					return;
				}
				AuthnRequestType authnRequestType = message as AuthnRequestType;
				if (authnRequestType != null)
				{
					AuthnRequestType authnRequestType2 = authnRequestType;
					authnRequestType2.ForceAuthn = false;
					authnRequestType2.IsPassive = true;
					authnRequestType2.ForceAuthnSpecified = false;
					authnRequestType2.IsPassiveSpecified = true;
				}
				this.MessageCreated(this, new Saml2MessageEventArgs(message));
			};
			ISaml2Message saml2Message = saml2Sender.SendMessage(Saml2MessageTypeEnum.AuthnRequest, "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect", config);
			store.SetExpirable(config, Saml2ControllerUtility.GetStoredAuthnRequestIDKey(saml2Message.ID), saml2Message.ID);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00008E2C File Offset: 0x0000702C
		internal void SingOut(Saml2Config config, UserDataStoreBase store)
		{
			this.logger.Info("Saml2ServiceProviderController.SingOut");
			ISaml2Principal samlPrincipal = config.HttpContext.ApplicationCurrentUser as ISaml2Principal;
			if (samlPrincipal == null)
			{
				throw new SignOutException("single logout not possible: HttpContext.Current.User is not ISaml2Principal");
			}
			ISaml2Sender saml2Sender = Saml2Config.CreateSender(this.logger);
			saml2Sender.MessageCreated += delegate(ISaml2Message message)
			{
				LogoutRequestType logoutRequestType = (LogoutRequestType)message;
				logoutRequestType.SessionIndex = new string[]
				{
					samlPrincipal.SessionIndex
				};
				logoutRequestType.Item = Saml2ControllerUtility.GetTicketNameID(config);
			};
			ISaml2Message saml2Message = saml2Sender.SendMessage(Saml2MessageTypeEnum.LogoutRequest, "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect", config);
			store.SetExpirable(config, Saml2ControllerUtility.GetStoredLogoutRequestIDKey(saml2Message.ID), saml2Message.ID);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00008ED0 File Offset: 0x000070D0
		internal ISaml2Message ProcessIncommingMessage(Saml2Config config, UserDataStoreBase store)
		{
			this.logger.Info("Saml2ServiceProviderController.ProcessIncommingMessage");
			ISaml2Message saml2Message = new ReceivePipeline(this.logger).ReadMessage(config);
			RequestAbstractType requestAbstractType = saml2Message as RequestAbstractType;
			if (requestAbstractType != null)
			{
				this.ProcessRequest(config, requestAbstractType, store);
				return saml2Message;
			}
			StatusResponseType statusResponseType = saml2Message as StatusResponseType;
			if (statusResponseType == null)
			{
				throw new Saml2ModuleException("message type not supported: " + saml2Message.GetType().Name);
			}
			this.ProcessResponse(config, statusResponseType, store);
			return saml2Message;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00008F44 File Offset: 0x00007144
		private void ProcessRequest(Saml2Config config, RequestAbstractType request, UserDataStoreBase store)
		{
			this.logger.Info("Saml2ServiceProviderController.ProcessRequest");
			LogoutRequestType logoutRequest = request as LogoutRequestType;
			if (logoutRequest == null)
			{
				throw new Saml2ModuleException("request message type not supported: " + request.GetType().Name);
			}
			ISaml2Sender saml2Sender = Saml2Config.CreateSender(this.logger);
			bool success = this.ProcessLogoutRequest(config, logoutRequest);
			saml2Sender.MessageCreated += delegate(ISaml2Message msg)
			{
				LogoutResponseType logoutResponseType = (LogoutResponseType)msg;
				logoutResponseType.InResponseTo = logoutRequest.ID;
				logoutResponseType.StatusCode = (success ? "urn:oasis:names:tc:SAML:2.0:status:Success" : "urn:oasis:names:tc:SAML:2.0:status:Responder");
			};
			saml2Sender.SendMessage(Saml2MessageTypeEnum.LogoutResponse, "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect", config);
			if (!success)
			{
				throw new SignOutException("single logout not possible: HttpContext.Current.User is not ISaml2Principal");
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00008FE8 File Offset: 0x000071E8
		private void ProcessResponse(Saml2Config config, ISaml2ResponseMessage response, UserDataStoreBase store)
		{
			this.logger.Info("Saml2ServiceProviderController.ProcessResponse");
			if (response.StatusCode != "urn:oasis:names:tc:SAML:2.0:status:Success" && !MessageUtility.HasNoPassiveStatusCode(response))
			{
				throw new Saml2ModuleException("response status code is not Success: " + response.StatusCode);
			}
			string text = null;
			if (response is ResponseType)
			{
				text = Saml2ControllerUtility.GetStoredAuthnRequestIDKey(response.InResponseTo);
			}
			if (response is LogoutResponseType)
			{
				text = Saml2ControllerUtility.GetStoredLogoutRequestIDKey(response.InResponseTo);
			}
			string value = null;
			if (!string.IsNullOrEmpty(text))
			{
				value = store.Get<string>(config, text);
			}
			if (string.IsNullOrEmpty(value))
			{
				throw new Saml2ModuleException("request " + response.InResponseTo + " was not found in cache for the response: " + response.ID);
			}
			string responseStatus = MessageUtility.GetResponseStatus(response);
			if (responseStatus != "urn:oasis:names:tc:SAML:2.0:status:Success" && !MessageUtility.HasNoPassiveStatusCode(response))
			{
				throw new Saml2ModuleException("response status is: " + responseStatus);
			}
			store.Clear(text);
			if (MessageUtility.HasNoPassiveStatusCode(response))
			{
				return;
			}
			ResponseType responseType = response as ResponseType;
			if (responseType != null)
			{
				this.ProcessAssertion(config, store, responseType.Assertion);
				store.Store(config);
				return;
			}
			store.Store(config);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000090FF File Offset: 0x000072FF
		private void ProcessAssertion(Saml2Config config, UserDataStoreBase store, AssertionType assertion)
		{
			this.logger.Info("Saml2ServiceProviderController.ProcessAssertion");
			store.Set(config, "SessionIndex", assertion.AuthnStatement.SessionIndex);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00009128 File Offset: 0x00007328
		private bool ProcessLogoutRequest(Saml2Config config, LogoutRequestType logoutRequest)
		{
			this.logger.Info("Saml2ServiceProviderController.ProcessLogoutRequest");
			if (!(config.HttpContext.ApplicationCurrentUser is ISaml2Principal))
			{
				return false;
			}
			NameIDType ticketNameID = Saml2ControllerUtility.GetTicketNameID(config);
			NameIDType nameIDType = logoutRequest.Item as NameIDType;
			return nameIDType != null && (ticketNameID.Value == nameIDType.Value && ticketNameID.Format == nameIDType.Format && ticketNameID.NameQualifier == nameIDType.NameQualifier) && ticketNameID.SPNameQualifier == nameIDType.SPNameQualifier;
		}

		// Token: 0x04000220 RID: 544
		private readonly ILog logger;
	}
}
