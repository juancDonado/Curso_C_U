using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO_9
{
    public interface ILog
    {
        void Log(string mensaje);
        void LogException(Exception err);
    }
    public class LoggerConsola : ILog
    {
        public void Log(string mensaje)
        {
            Console.WriteLine($"{DateTime.Now}: {mensaje}");
        }
        public void SetearColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public void LogException(Exception err)
        {
            SetearColor(ConsoleColor.Red);
            string error = $"{err.Message}: {err.StackTrace}";
            Log(error);
            SetearColor(ConsoleColor.White);
        }
    }
    public class LoggerArchivoDeTexto : ILog
    {
        public void Log(string mensaje)
        {
            using (StreamWriter writetext = new StreamWriter(@"c:\log.txt", append: true))
            {
                writetext.WriteLine(mensaje);
            }
        }
        public void LogException(Exception err)
        {
            string error = $"{err.Message}: {err.StackTrace}";
            Log(error);
        }
    }
}
