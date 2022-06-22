using System;
using System.Collections.Generic;

namespace ProgramacionOO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona();
            persona1.telefonos.Add("30015232");
            var persona2 = new Persona("Juan", 1000);
            persona2.telefonos.Add("300154512");
        }

        public static void procesarRepositorio(IRepositorioPersonas repositorio)
        {
            repositorio.ObtenerPersonas();
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
        public decimal SalarioMensual { get; set; }
        public decimal SalarioAnual { get { return SalarioMensual * 12; } }
        public List<string> telefonos { get; set; }
        public void hablar() { }
        public void hablar(string mensaje) { }
        public void hablar(string mensaje, int numero) { }
        public void hablar(int numero, string mensaje) { }
    }    
}
