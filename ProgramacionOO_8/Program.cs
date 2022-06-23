using System;

namespace ProgramacionOO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Alerta.MostarMensajeError("Este es un mensaje de eror");
            Alerta.MostarMensajePeligro("Esta es una alerta de peligro");
            Alerta.MostarMensajeExitoso("Proceso exitoso");
        }

        public enum TipoAlerta
        {
            PorDefecto,
            Exito,
            Peligro,
            Error
        }

        public static class Alerta
        {
            public static void MostarMensajeExitoso(string mensaje)
            {
                MostrarMensaje(mensaje, TipoAlerta.Exito);
            }
            public static void MostarMensajePeligro(string mensaje)
            {
                MostrarMensaje(mensaje, TipoAlerta.Peligro);
            }
            public static void MostarMensajeError(string mensaje)
            {
                MostrarMensaje(mensaje, TipoAlerta.Error);
            }
            private static void MostrarMensaje(string mensaje, TipoAlerta tipoMensaje)
            {
                var colorPorDefecto = ConsoleColor.White;
                switch (tipoMensaje)
                {
                    case TipoAlerta.Exito:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case TipoAlerta.Peligro:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case TipoAlerta.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        Console.ForegroundColor = colorPorDefecto;
                        break;
                }
                Console.WriteLine(mensaje);
                Console.ForegroundColor = colorPorDefecto;
            }
        }
        
    }
}
