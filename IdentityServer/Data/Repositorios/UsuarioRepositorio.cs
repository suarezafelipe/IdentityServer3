using IdentityServer.Data.Modelos;
using System;
using System.Threading.Tasks;

namespace IdentityServer.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public Usuario GetUsuario(string contextUserName, string contextPassword)
        {
            // temp
            var usuario = new Usuario()
            {                
                Nombre = "felipe",
                Contrasena = "password"
            };

            return usuario;
        }
    }
}
