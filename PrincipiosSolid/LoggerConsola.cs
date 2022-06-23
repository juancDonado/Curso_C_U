using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid
{
    public class LoggerConsola
    {
        public void Log(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        public void LogException(Exception err)
        {
            string error = $"{err.Message}: {err.StackTrace}";
            Log(error);
        }
    }
}
