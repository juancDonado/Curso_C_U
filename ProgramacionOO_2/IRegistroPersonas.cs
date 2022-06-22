﻿using System;

namespace ProgramacionOO_2
{
    public interface IRepositorioPersonas
    {
        void ObtenerPersonas();
    }
    public class RepositorioPersonasBD : IRepositorioPersonas, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public void ObtenerPersonas()
        {
            Console.WriteLine("Obtener personas de la base de datos");
        }
    }

    public class RepositorioPersonasEnMemoria : IRepositorioPersonas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("Obteniendo personas de la memoria");
        }
    }
}