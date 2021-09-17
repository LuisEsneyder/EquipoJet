using system;
namespace FinananzasMiHogar.App.Dominio
{
    /// <summary> Class <c>Usuarios</c>
    /// Modela a los usuarios en el sistema
    /// </summary>
    public class Usuarios
    {
        //Atributos
        public string nombreUsuario {get; set;}
        public string correoElectronico {get; set;}
        public Gastos gasto {get; set;}
        public int topeGastos {get; set;} 
    }
}