using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer.Data.Repositorios;
using IdentityServer.Utilidades;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;
using IdentityServer3.Core.Services.Default;

namespace IdentityServer
{
    public class UserService : UserServiceBase
    {
	    private readonly IUsuarioRepositorio _userRepository;

	    public UserService(IUsuarioRepositorio userRepository)
	    {
		    _userRepository = userRepository;
	    }
	    public override async Task AuthenticateLocalAsync(LocalAuthenticationContext context)
	    {
		    var user = _userRepository.GetUsuario(context.UserName,
                HashHelper.Sha512(context.Password + context.UserName));

		    if (user == null)
		    {
				context.AuthenticateResult = new AuthenticateResult("Incorrect ");
			    return;
		    }

			context.AuthenticateResult = new AuthenticateResult(context.UserName, context.UserName);
	    }
    }
}
