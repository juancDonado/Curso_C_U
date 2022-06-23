﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(new int[] { 1, 4 });
            Vector vector2 = new Vector(new int[] { 2, 5 });

            var vectorSuma = vector1 + vector2;
        }
    }

    public class Vector
    {
        public Vector(int[] valores)
        {
            vector = valores;
        }
        private int[] vector { get; set; }
        public int Dimension { get { return vector.Length; } }
        public int this[int i]
        {
            get { return vector[i]; }
            set { vector[i] = value; }
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return Sumar(v1, v2);
        }

        private static Vector Sumar(Vector vector1, Vector vector2)
        {
            if (vector1.Dimension != vector2.Dimension)
            {
                throw new ApplicationException("No puedes sumar dos vectores de dimensiones diferentes");
            }

            int dimension = vector1.Dimension;
            int[] resultado = new int[dimension];
            for (int i = 0; i < dimension; i++)
            {
                resultado[i] = vector1[i] + vector2[i];
            }
            var vectorSuma = new Vector(resultado);

            return vectorSuma;
        }
    }
}
