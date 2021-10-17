using System;
using System.Collections.Generic;
using System.Linq;
using FinanzasMiHogar.App.Dominio;
using FinanzasMiHogar.App.Persistencia;
namespace FinanzasMiHogar.App.Persistencia
{
    public class RepoGastos : IGastos
    {
        ///<summary>
        /// Referencia al contexto de Paciente 
        ///</summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo utiliza inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="MyappContext"></param>//
        public RepoGastos(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Gastos AddUGastos(string NombreGasto, int ValorGasto,DateTime FechaPago)
        {
            try
            {
            if(NombreGasto==null & ValorGasto==0 & FechaPago==null)
            {
                 return null;
            }
            else{ 
                var gastos = new Gastos{
                nombreGastos=NombreGasto,
                montoDinero=ValorGasto,
                fechaPago=FechaPago
                };

            var GastoAdicionado = _appContext.gasto.Add(gastos);
            _appContext.SaveChanges();
            return GastoAdicionado.Entity;
            } 
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}