using IdentityServer.Data.Modelos;
using System.Threading.Tasks;

namespace IdentityServer.Data.Repositorios
{
    public interface IUsuarioRepositorio
    {
	    Usuario GetUsuario(string contextUserName, string contextPassword);
    }
}
