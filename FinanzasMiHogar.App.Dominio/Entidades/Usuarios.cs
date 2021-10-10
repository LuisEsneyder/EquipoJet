using System;
using System.ComponentModel.DataAnnotations;
namespace FinanzasMiHogar.App.Dominio
{
    /// <summary> Class <c>Usuarios</c>
    /// Modela a los usuarios en el sistema
    /// </summary>
    public class Usuarios
    {
        //Atributos
        public int Id {get; set;}
        [Required, StringLength(50)]
        public string nombreUsuario {get; set;}
        [Required, StringLength(50)]
        public string correoElectronico {get; set;}
        [Required, StringLength(50)]
        public string contraseña {get; set;}
        public Gastos gasto {get; set;}
        public int topeGastos {get; set;} 
    }
}