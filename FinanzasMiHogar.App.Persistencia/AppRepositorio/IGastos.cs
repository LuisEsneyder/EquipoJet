using System;
using FinanzasMiHogar.App.Dominio;
namespace FinanzasMiHogar.App.Persistencia

{
    public interface IGastos
    {
         Gastos AddUGastos(string NombreGasto, int ValorGasto,DateTime FechaPago);
    }
}