using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens.Saml2;
using Kentor.AuthServices;
using Kentor.AuthServices.Metadata;
using Kentor.AuthServices.WebSso;
using System.Security.Cryptography.X509Certificates;
using IdentityServer4;
using Microsoft.Extensions.Configuration;
using Kentor.AuthServices.Saml2P;

namespace AuthServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApiResources())
                .AddInMemoryClients(Config.GetClients())
                .AddTestUsers(Config.GetUsers());

            //IDP: https://stubidp.sustainsys.com/
            //var samlIdentityUrl = "https://localhost:5000";
            //var samlMetadataUrl = "https://stubidp.sustainsys.com/Metadata";
            //var samlSignOnUrl = "https://stubidp.sustainsys.com/";
            //var certificate = "stubidp.sustainsys.com.cer";

            //IDP: https://auth.vyvoj.upvs.globaltel.sk/oamfed/idp/samlv20 // https://portal.vyvoj.upvs.globaltel.sk/sk/obcan
            //note: new line of code options.SPOptions.RequestedAuthnContext
            var samlIdentityUrl = "http://localhost.rbconcepts";
            var samlMetadataUrl = "https://auth.vyvoj.upvs.globaltel.sk/oamfed/idp/metadata";
            var samlSignOnUrl = "https://auth.vyvoj.upvs.globaltel.sk/oamfed/idp/samlv20";
            var certificate = "rbteam.test.cer";
            
            services.AddAuthentication()
                .AddSaml2(options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                    options.SPOptions.EntityId = new Saml2NameIdentifier(samlIdentityUrl);
                    options.SPOptions.RequestedAuthnContext = new Saml2RequestedAuthnContext(new Uri("urn:upvs:qaalevel:1"), AuthnContextComparisonType.Minimum);
                    //options.SPOptions.ServiceCertificates.Add(new ServiceCertificate()
                    //{
                    //    Certificate = new X509Certificate2("rbteam.test.pfx"),
                    //    Use = CertificateUse.Both
                    //});

                    var idp = new IdentityProvider(new EntityId(samlMetadataUrl), options.SPOptions)
                    {
                        SingleSignOnServiceUrl = new Uri(samlSignOnUrl),
                        //WantAuthnRequestsSigned = true,
                        Binding = Saml2BindingType.HttpRedirect
                    };

                    idp.SigningKeys.AddConfiguredKey(new X509Certificate2(certificate));
                    options.IdentityProviders.Add(idp);
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseIdentityServer();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseBrowserLink();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}

            //app.UseStaticFiles();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseIdentityServer();

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
