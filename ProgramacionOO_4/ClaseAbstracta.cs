using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionOO_4
{
    class ClaseAbstracta
    {
        //static void Main(string[] args)
        //{
        //    Animal perro = new Perro("Felipe");
        //    //ProcesarAnimal(perro);
        //    //ProcesarAnimal(new Gato());
        //}

        static void ProcesarAnimal(Animal animal)
        {
            animal.HacerRuido();
        }
    }

    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Constructor de la clase animal");
        }
        public Animal(string param)
        {
            Console.WriteLine($"{param} en la clase animal");
        }
        //public abstract void HacerRuido();
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido generico");
        }
    }

    public class Perro : Animal
    {
        public Perro()
        {
            Console.WriteLine("Constructor de la clase perro");
        }
        public Perro(string param1)
            : base(param1)
        {
            Console.WriteLine("Consultor de la clase perro con parametro");
        }
        public override void HacerRuido()
        {
            Console.WriteLine("Guau Guau");
        }
    }

    public class Gato : Animal
    {

    }
}