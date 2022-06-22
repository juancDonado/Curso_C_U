using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionOO_3
{
    public static class UtilidadesDeFechas
    {
        public static int CalcularEdad(this DateTime fechaNacimiento)
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year, fechaNacimiento.Month, fechaNacimiento.Day);

            if (temp > DateTime.Today) edad--;
            
            return edad;
        }
    }
    public static class UtilidadesDeString
    {
        public static int ContarVocales(this string valor)
        {
            if(valor == null)
            {
                throw new ArgumentException("El valor no puede ser nulo");
            }

            int resultado = 0;
            string vocales = "aeiou";
            valor = valor.ToLower();

            foreach(var caracter in valor)
            {
                resultado++;
            }
            return resultado;
        }
    }
}
