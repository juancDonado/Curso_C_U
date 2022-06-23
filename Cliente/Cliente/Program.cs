using System;
using Libreria;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var clasePublica = new ClasePublicaDePrueba();
            clasePublica.MetodoPublico();

            //clasePublica.PropiedadProtectedInternal;
            //clasePublica.PropiedadInterna;
            //var claseInterna = new ClaseInternaDePrueba();
            //Console.WriteLine("Hello World!");
        }
    }

    public class ClaseDerivada : ClasePublicaDePrueba
    {
        public void Prueba()
        {
            //PropiedadPrivateProtected = "gg";
            PropiedadProtectedInternal = "gg";
            PropiedadProtegida = 3;
        }
    }
}
