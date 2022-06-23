using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO_9
{
    public class FactorialLoggers
    {
        public ILog ObtenerLogger(string discriminante)
        {
            switch (discriminante)
            {
                case "consola":
                    return new LoggerConsola();
                case "archivo":
                    return new LoggerArchivoDeTexto();
                default:
                    throw new NotImplementedException("Logger not found");
            }
        }
    }
}
