using System;
/// <summary> Class <c>Gastos</c>
/// Modela una clase de Gastos
/// </summary>
namespace FinanzasMiHogar.App.Dominio
{
    public class Gastos
    {   
        //Identificador de gastos
        public int Id {get; set;}
        public string nombreGastos {get; set;}
        public int montoDinero {get; set;}
        public DateTime fechaPago {get; set;}
        public TipoGasto TipoGasto {set; get;}
        public PeriodoGastos periodoGastos {get; set;}
    }
}