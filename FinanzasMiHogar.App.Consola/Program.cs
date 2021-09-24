using System;
using FinanzasMiHogar.App.Dominio;
using FinanzasMiHogar.App.Persistencia;

namespace FinanzasMiHogar.App.Consola
{
    class Program
    {
        private static IGastos _repoGasto = new RepoGastos(new Persistencia.AppContext());
        private static IRepositorioUsuario _repoUsuario = new RepositorioUsuario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddUsuario();
            AddGasto();
        }
        public static void AddGasto()
        {
            var Gastoss = new Gastos
            {
                
                nombreGastos = "Prueba",
                montoDinero = 100000,
                fechaPago="Prueba2",
                
            };
            _repoGasto.AddUGastos(Gastoss);
        }
       public static void AddUsuario()
        {   
            var usuario = new Usuarios
            {
                
                nombreUsuario="Prueba 1",
                correoElectronico ="@Prueba1",
                topeGastos=100000
            };
            _repoUsuario.AddUsuario(usuario);
        }
    }
}
