using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FinanzasMiHogar.App.Persistencia;
using FinanzasMiHogar.App.Dominio;

namespace FinanzasMiHogar.App.FrontEnd
{
    public class GastosModel : PageModel
    {
        public readonly Persistencia.IRepositorioUsuario repositorioUsuario;
        public readonly Persistencia.IGastos repoGastos;
        [BindProperty]
        public Usuarios usuario {get; set;}
        [BindProperty]
        public Gastos gastos {get; set;}
        
        public GastosModel()
        {
            this.repositorioUsuario = new RepositorioUsuario (new FinanzasMiHogar.App.Persistencia.AppContext());
            this.repoGastos = new RepoGastos (new FinanzasMiHogar.App.Persistencia.AppContext()); 
        }
        [BindProperty(SupportsGet =true)]
        string nombreGasto{get;set;}
        [BindProperty(SupportsGet =true)]
        int ValorGasto{get;set;}
        [BindProperty(SupportsGet =true)]
        DateTime FechaPago{get;set;}
        public IActionResult OnGet(string NombreGasto, int ValorGasto,DateTime FechaPago)
        {
            this.nombreGasto=nombreGasto;
            this.ValorGasto=ValorGasto;
            this.FechaPago=FechaPago;
            gastos=repoGastos.AddUGastos(NombreGasto, ValorGasto, FechaPago);
            if(gastos!=null)
            {
                return Page();
            }
            else{
                return Content("Mal");
            }
        }
    }
}
