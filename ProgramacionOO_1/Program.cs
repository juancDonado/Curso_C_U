using System;

namespace ProgramacionOO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona() { Nombre = "Juan" };
            Console.WriteLine($"Nombre antes del cambio: {persona1.Nombre}");
            cambiarNombre(persona1);
            Console.WriteLine($"Nombre despues del cambio: {persona1.Nombre}");

            var numero = 1;
            aumentar(ref numero);
            Console.WriteLine(numero);

            Console.WriteLine(sumar(10,5));
        }
        public static int sumar(int num1, int num2) => num1 + num2;

        public static void cambiarNombre(Persona persona)
        {
            persona.Nombre = "Nombre cambiado";
        }

        public static void aumentar(ref int numero)
        {
            numero++;
        }
        public class Persona
        {
            public string Nombre { get; set; }
            public decimal SalarioMensual { get; set; }
            public decimal SalarioAnual { get { return SalarioMensual * 12; } }
        }
    }
}
