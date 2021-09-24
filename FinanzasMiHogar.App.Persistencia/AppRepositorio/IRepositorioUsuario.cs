using FinanzasMiHogar.App.Dominio;
namespace FinanzasMiHogar.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        
         Usuarios AddUsuario(Usuarios usuarios);
    }
}