using System;
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
            _appContext = appContext;
        }
        public Usuarios AddUsuario( string nombre,string correo,string contraseña)
        {   
            try
            {
                if(correo==null & contraseña == null)
            {
                 return null;
            }
            else{ 
                var Usuario = new Usuarios{
                nombreUsuario = nombre,
                correoElectronico = correo,
                contraseña = contraseña
                };

            var UsuarioAdicionado = _appContext.usuario.Add(Usuario);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
            } 
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
        public Usuarios ValidacionUsuario(string correo, string contra)
        {
            
            
                var UsuarioEncontrado=_appContext.usuario.FirstOrDefault(U => U.correoElectronico == correo & U.contraseña==contra);
               return UsuarioEncontrado;
            
           
        }

    }
}
