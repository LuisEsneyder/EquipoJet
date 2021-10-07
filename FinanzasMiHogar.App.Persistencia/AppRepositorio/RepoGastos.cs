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
        private readonly MyAppContext _appContext;
        /// <summary>
        /// Metodo utiliza inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="MyappContext"></param>//
        public RepoGastos(MyAppContext appContext)
        {
            _appContext = appContext;
        }
        public Gastos AddUGastos(Gastos gastos)
        {
            try
            {
                var GastoAdicionado = _appContext.gasto.Add(gastos);
                _appContext.SaveChanges();
                return GastoAdicionado.Entity;
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}