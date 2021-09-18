using System;
/// <summary> Class <c>Gastos</c>
/// Modela una clase de Gastos
/// </summary>
namespace FinanzasMiHogar.App.Dominio
{
    public class Gastos
    {
        public string nombreGastos {get; set;}
        public int montoDinero {get; set;}
        public string fechaPago {get; set;}
        public TipoGasto tiposGastos {set; get;}
        public PeriodoGastos periodoGastos {get; set;}
    }
}