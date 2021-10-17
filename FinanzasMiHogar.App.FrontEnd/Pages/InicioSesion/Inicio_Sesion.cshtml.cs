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
        [BindProperty(SupportsGet =true)]
        string contra{get;set;}
        [BindProperty(SupportsGet =true)]
        string correo {get;set;}
       
        
        public IActionResult OnGet(string correo, string contra)
        {   
            
            this.contra=contra;
            this.correo=correo;
            Usuario = repositorioUsuario.ValidacionUsuario(correo,  contra);
            
            if (Usuario==null)
            {
                return Page();
            }
            else{
                return RedirectToPage("../Gastos/Gastos");
            }
        }
    }
}
