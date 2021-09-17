using system;
/// <summary> Class <c>Gastos</c>
/// Modela una clase de Gastos
/// </summary>
namespace FinananzasMiHogar.App.Dominio
{
    public class Gastos
    {
        public string nombreGastos {get; set;}
        public int montoDinero {get; set;}
        public string fechaPago {get; set;}
        public TipoGasto tiposGastos {get; set;}
        public PeriodoGastos periodoGastos {get; set;}
    }
}