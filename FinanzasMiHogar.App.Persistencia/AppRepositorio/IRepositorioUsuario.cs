using FinanzasMiHogar.App.Dominio;
namespace FinanzasMiHogar.App.Persistencia
{
    public interface IRepositorioUsuario
    {
         Usuarios AddUsuario(string nombre,string correo,string contraseña);
         Usuarios GetUsuarios(int idusuario);
       Usuarios ValidacionUsuario(string correo, string contra);
     
    }
}