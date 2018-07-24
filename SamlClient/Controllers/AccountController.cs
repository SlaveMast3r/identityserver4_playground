using SamlClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SamlClient.Controllers
{
    [Authorize]
    public class AccountController: Controller
    {
        [AllowAnonymous]
        public ActionResult SignIn()
        {
            RBTeam.Saml2Lib.Saml2Module.Instance.SignIn();
            return new EmptyResult();
        }

        [AllowAnonymous]
        public ActionResult SignInByHash(string hash)
        {
            RBTeam.Saml2Lib.Saml2Module.Instance.SignIn();
            return new EmptyResult();
        }

        [Authorize]
        public ActionResult AccountInfo()
        {
            return View(new AccountModel());
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            RBTeam.Saml2Lib.Saml2Module.Instance.SignOut("~/");
            return new EmptyResult();
        }
    }
}