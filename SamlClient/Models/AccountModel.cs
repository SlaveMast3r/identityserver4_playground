using RBTeam.Saml2Lib.Data.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;

namespace SamlClient.Models
{
    public class AccountModel
    {
        private readonly HttpContext context;

        [Display(Name = "Meno pouzivatela")]
        public string Name
        {
            get
            {
                return GetSamlPrincipal()?.Identity.Name;
            }
        }

        [Display(Name = "Typ prihlasenia")]
        public string AuthenticationType
        {
            get
            {
                return GetSamlPrincipal()?.Identity.AuthenticationType;
            }
        }

        [Display(Name = "Subject Name Id")]
        public string NameID
        {
            get
            {
                return GetSamlPrincipal()?.NameID;
            }
        }

        [Display(Name = "Session index")]
        public string SessionIndex
        {
            get
            {
                return GetSamlPrincipal()?.SessionIndex;
            }
        }

        [Display(Name = "Claims")]
        public IEnumerable<Tuple<string, string>> Claims
        {
            get
            {
                List<Tuple<string, string>> list = new List<Tuple<string, string>>();
                ISaml2Principal samlPrincipal = GetSamlPrincipal();
                if (samlPrincipal?.Claims == null)
                {
                    return list;
                }
                foreach (string key in samlPrincipal.Claims.Keys)
                {
                    list.AddRange(from value in samlPrincipal.Claims[key]
                                  select new Tuple<string, string>(key, value));
                }
                return list;
            }
        }

        [Display(Name = "Roles")]
        public IEnumerable<string> Roles
        {
            get
            {
                return GetSamlPrincipal()?.Roles;
            }
        }

        public SecurityToken BootstrapToken => (GetSamlPrincipal().Identity as ISaml2Identity)?.BootstrapToken;

        public AccountModel()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                context = HttpContext.Current;
            }
        }

        private ISaml2Principal GetSamlPrincipal()
        {
            return (ISaml2Principal)(context?.User);
        }
    }
}