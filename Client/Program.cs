using IdentityModel.Client;
using System;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        private static async Task MainAsync()
        {
            // discover endpoints from the metadata by calling Auth server hosted on 5000 port
            var discoveryClient = await DiscoveryClient.GetAsync("http://localhost:5000");
            if (discoveryClient.IsError)
            {
                Console.WriteLine(discoveryClient.Error);
                Console.ReadKey();
                return;
            }

            var response = await PasswordProtected(discoveryClient);

            if (response.IsError)
            {
                Console.WriteLine(response.Error);
                Console.ReadKey();
                return;
            }

            Console.WriteLine(response.Json);
            Console.ReadKey();
        }

        private static Task<TokenResponse> TwoLegged(DiscoveryResponse discoveryClient)
        {
            // request the token from the Auth server
            var tokenClient = new TokenClient(discoveryClient.TokenEndpoint, "client", "secret");

            return tokenClient.RequestClientCredentialsAsync("api1");
        }

        private static Task<TokenResponse> PasswordProtected(DiscoveryResponse discoveryClient)
        {
            var tokenClient = new TokenClient(discoveryClient.TokenEndpoint, "ro.client", "secret");

            return tokenClient.RequestResourceOwnerPasswordAsync("alice", "password", "api1");
        }
    }
}
