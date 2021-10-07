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
        private readonly MyAppContext _appContext;
        /// <summary>
        /// Metodo utiliza inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioUsuario(MyAppContext appContext)
        {
            _appContext = appContext;
        }
        public Usuarios AddUsuario(Usuarios usuarios)
        {
            try
            {
                var UsuarioAdicionado = _appContext.usuario.Add(usuarios);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity; 
            }
            catch (System.Exception)
            {
                throw;
            }
            
        }
        public Usuarios GetUsuarios(int idusuario)
        {
           return _appContext.usuario.FirstOrDefault(U => U.Id == idusuario);
        }
        
    }
}