using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FinanzasMiHogar.App.Persistencia;
using FinanzasMiHogar.App.Dominio;

namespace FinanzasMiHogar.App.FrontEnd.Pages
{
    public class Inicio_SesionModel : PageModel
    {
        public readonly Persistencia.IRepositorioUsuario repositorioUsuario;
        [BindProperty]
        public Usuarios Usuario {get; set;}
        
        public Inicio_SesionModel()
        {
            this.repositorioUsuario = new RepositorioUsuario (new FinanzasMiHogar.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
        }
    }
}
