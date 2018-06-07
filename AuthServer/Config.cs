using IdentityServer4.Models;
using IdentityServer4.Quickstart.UI;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer
{
    public class Config
    {
        // clients that are allowed to access resources from the Auth server 
        public static IEnumerable<Client> GetClients()
        {
            // client credentials, list of clients
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
 
                    // Client secrets
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "api1" }
                },
                
                // resource owner password grant client
                new Client
                {
                    ClientId = "ro.client",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "api1" }
                },
            };
        }

        // API that are allowed to access the Auth server
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "My API")
            };
        }

        public static List<TestUser> GetUsers()
        {
            return TestUsers.Users;

            //return new List<TestUser>
            //{
            //    new TestUser
            //    {
            //        SubjectId = "1",
            //        Username = "alice",
            //        Password = "password"
            //    },
            //    new TestUser
            //    {
            //        SubjectId = "2",
            //        Username = "bob",
            //        Password = "password"
            //    }
            //};
        }
    }
}
