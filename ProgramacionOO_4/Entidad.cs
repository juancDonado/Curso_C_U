using System;

namespace Programacion00_4
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Persona persona = new Persona();
    //        Producto producto = new Producto();

    //        Console.WriteLine("Hello World!");
    //    }
    //}

    public class Entidad
    {
        public int Id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }

    public class Persona : Entidad
    {
        public string nombre { get; set; }
    }
    public class Producto : Entidad
    {
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}

