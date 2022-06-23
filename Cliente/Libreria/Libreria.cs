using System;

namespace Libreria
{
    public class ClienteDentroDeLibreria
    {
       public void Prueba()
        {
            var clasePublica = new ClasePublicaDePrueba();
            //clasePublica.MetodoPrivado();
            clasePublica.PropiedadInterna = "b";
            clasePublica.PropiedadProtectedInternal = "GG";
            var claseInterna = new ClaseInternaDePrueba();
        }
    }
    public class ClasePublicaDePrueba
    {
        public void MetodoRecibeClaseInterna(ClaseInternaDePrueba claseInterna)
        {

        }
        //Metodos Publicos y propiedades publicas
        public int PropiedadClinete { get; set; }
        internal string PropiedadInterna { get; set; }
        protected int PropiedadProtegida { get; set; }
        protected internal string PropiedadProtectedInternal { get; set; }
        private protected string PropiedadPrivateProytected { get; set; }
        public void MetodoPublico()
        {
            PropiedadInterna = "oasd";
            PropiedadProtegida = 1;
            PropiedadClinete = 1;
            MetotoPrivado();
        }

        private void MetotoPrivado()
        {

        }
    }

    internal class ClaseInternaDePrueba 
    { 

    }

    public class PublicDerivada : ClasePublicaDePrueba
    {
        public void Prueba()
        {
            PropiedadPrivateProytected = "Hola";
        }
    }
}
