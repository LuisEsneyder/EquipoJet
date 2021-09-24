using System.Collections.Generic;
using System.Linq;
using FinanzasMiHogar.App.Dominio;
using FinanzasMiHogar.App.Persistencia;
namespace FinanzasMiHogar.App.Persistencia
{
   

    public class RepositorioUsuario : IRepositorioUsuario
    {
        ///<summary>
        /// Referencia al contexto de Paciente 
        ///</summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo utiliza inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioUsuario(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Usuarios AddUsuario(Usuarios usuarios)
        {
            var UsuarioAdicionado = _appContext.usuario.Add(usuarios);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
    }
}