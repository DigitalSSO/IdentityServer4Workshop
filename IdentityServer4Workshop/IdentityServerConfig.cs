using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace IdentityServer4Workshop
{
    public static class IdentityServerConfig
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<ApiResource> GetApis(IConfiguration configuration)
        {
            return new List<ApiResource>
            {
            };
        }

        public static IEnumerable<Client> GetClients(IConfiguration configuration)
        {
            return new List<Client> {
                new Client()
                {
                    ClientId = "Mobile",
                    ClientName = "Mobile service",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets ={
                        new Secret("fU7fRb+g6YdlniuSqviOLWNkda1M/MuPtH6zNI9inF8=".Sha256())
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                    }
                }
            };
        }

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser> {
                new TestUser()
                {
                    SubjectId = "test",
                    Username = "test",
                    Password = "test",
                    IsActive = true
                }
            };
        }
    }
}
