using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer.Data.Repositorios;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;
using IdentityServer3.Core.Services.Default;

namespace IdentityServer
{
    public class UserService : UserServiceBase
    {
	    private readonly IUserRepositorio _userRepository;

	    public UserService(IUserRepositorio userRepository)
	    {
		    _userRepository = userRepository;
	    }
	    public override async Task AuthenticateLocalAsync(LocalAuthenticationContext context)
	    {
		    var user = await _userRepository.GetAsync(context.UserName, context.Password); //TODO use HashHelper.Sha512 with key + salt

		    if (user == null)
		    {
				context.AuthenticateResult = new AuthenticateResult("Incorrect ");
			    return;
		    }

			context.AuthenticateResult = new AuthenticateResult(context.UserName, context.UserName);
	    }
    }
}
