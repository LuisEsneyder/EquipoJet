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
        /// <param name="appContext"></param>//
        public RepoGastos(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Gastos AddUGastos(Gastos gastos)
        {
            var GastoAdicionado = _appContext.gasto.Add(gastos);
            _appContext.SaveChanges();
            return GastoAdicionado.Entity;
        }
    }
}