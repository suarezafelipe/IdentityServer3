using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Data.Repositorios
{
    public interface IUserRepositorio
    {
	    object GetAsync(string contextUserName, string contextPassword);
    }
}
