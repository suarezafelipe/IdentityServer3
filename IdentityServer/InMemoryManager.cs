using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer3.Core;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services.InMemory;

namespace IdentityServer
{
    public static class InMemoryManager
    {
	    public static List<InMemoryUser> GetUsers()
	    {
		    return new List<InMemoryUser>
		    {
			    new InMemoryUser
			    {
				    Subject = "admin@example.com",
				    Username = "admin",
				    Password = "password",
				    Claims = new[]
				    {
					    new Claim(Constants.ClaimTypes.Name, "Pedro Perez"),
				    }
			    }
		    };
	    }

	    public static IEnumerable<Scope> GetScopes()
	    {
		    return new[]
		    {
				StandardScopes.OpenId,
				StandardScopes.Profile,
				StandardScopes.OfflineAccess,
				new Scope
				{
					Name = "admin",
					DisplayName = "Administrador"
				},
				new Scope
				{
					Name = "user",
					DisplayName = "Cliente"
				}
		    };
	    }

	    public static IEnumerable<Client> GetClients()
	    {
		    return new[]
		    {
			    new Client
			    {
				    ClientId = "alquilarauto",
				    ClientSecrets = new List<Secret>
				    {
					    new Secret("secret".Sha512())
				    },
				    ClientName = "AlquilarAuto",
				    Flow = Flows.Hybrid,
				    AllowedScopes = new List<string>
				    {
					    Constants.StandardScopes.OpenId,
					    "admin",
						"user"
				    },
					Enabled = true
			    }
		    };
	    }
    }
}
