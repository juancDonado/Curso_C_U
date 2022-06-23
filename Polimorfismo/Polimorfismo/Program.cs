using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    ProcesarAnimal(new Perro());
        //    ProcesarAnimal(new Gato());
        //}
        static void ProcesarAnimal(Animal animal)
        {
            animal.HacerRuido();
        }
    }
    public abstract class Animal 
    {
        public abstract void HacerRuido();
    }
    public class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Guau Guau");
        }
    }

    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau Miau");
        }
    }
}
