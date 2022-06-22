using System;
using System.Collections.Generic;

namespace ProgramacionOO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = null;
            var resultado = nombre.ContarVocales();

            var persona = new Persona() { FechaNacimiento = new DateTime(2001,5,25)};
            Console.WriteLine("La edad es: "+persona.Edad);

            var persona1 = new Persona();
            persona1.telefonos.Add("30015232");
            var persona2 = new Persona("Juan", 1000);
            persona2.telefonos.Add("300154512");

            procesarRepositorio(new RepositorioPersonasBD());
            procesarRepositorio(new RepositorioPersonasEnMemoria());

            var repositorio = ObtenerRepositorio(TipoRepositorio.BD);
            procesarRepositorio(repositorio);
        }
        public static void procesarRepositorio(IRepositorioPersonas repositorio)
        {
            repositorio.ObtenerPersonas();
        }

        enum TipoRepositorio { Memoria = 1, BD = 2 }

        static IRepositorioPersonas ObtenerRepositorio(TipoRepositorio tipoRepositorio)
        {
            switch (tipoRepositorio)
            {
                case TipoRepositorio.Memoria:
                    return new RepositorioPersonasEnMemoria();
                    break;
                case TipoRepositorio.BD:
                    return new RepositorioPersonasBD();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public class Persona
    {
        public Persona()
        {
            Console.WriteLine("constructor persona");
            telefonos = new List<string>();
        }
        public Persona(string nombre, decimal salarioMensual)
            : this()
        {
            Nombre = nombre;
            SalarioMensual = salarioMensual;
        }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad
        {
            get
            {
                return FechaNacimiento.CalcularEdad();
                //return UtilidadesDeFechas.CalcularEdad(FechaNacimiento);
            }
        }
        public decimal SalarioMensual { get; set; }
        public decimal SalarioAnual { get { return SalarioMensual * 12; } }
        public List<string> telefonos { get; set; }
        public void hablar() { }
        public void hablar(string mensaje) { }
        public void hablar(string mensaje, int numero) { }
        public void hablar(int numero, string mensaje) { }
    }
}
