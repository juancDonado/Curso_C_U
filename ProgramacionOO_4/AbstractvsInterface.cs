using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO_4
{
    class AbstractvsInterface
    {
        static void Main()
        {
            var loggerConsola = new LoggerConsola();
            var loggerArchivo = new LoggerArchivo();

            ProbarLogger(loggerConsola);
            ProbarLogger(loggerArchivo);
        }

        static void ProbarLogger(LoggerBase logger)
        {
            logger.Log("Probando el logger");
            try
            {
                throw new NotImplementedException("Prueba de excepcion");
            }
            catch (NotImplementedException err)
            {
                logger.LogException(err);
            }
        }
    }

    abstract class LoggerBase
    {
        public abstract void Log(string mensaje);
        public virtual void LogException(Exception err) => Log(err.Message);
    }

    class LoggerConsola : LoggerBase
    {
        public override void Log(string mensaje) => Console.WriteLine(mensaje);

        public override void LogException(Exception err)
        {
            Log($"{err.Message}: {err.StackTrace}");
        }
    }

    class LoggerArchivo : LoggerBase
    {
        public override void Log(string mensaje)
        {
            using (StreamWriter writetext = new StreamWriter($@"{Directory.GetCurrentDirectory()}\log.txt", append: true))
            {
                writetext.WriteLine($"{DateTime.Now}: {mensaje}");
            }
        }
    }
}