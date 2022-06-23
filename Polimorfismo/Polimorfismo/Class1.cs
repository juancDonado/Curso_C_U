using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Polimorfismo
    {
        static void Main(String[] args)
        {
            ProcesarRepositorio(new RepositorioPersonasDB());
            ProcesarRepositorio(new RepositorioPersonasEnMemoria());
        }
        static void ProcesarRepositorio(IRepositorioPersonas repositorio)
        {
            repositorio.ObtenerPersonas();
        }
    }
    
    public interface IRepositorioPersonas
    {
        void ObtenerPersonas();
    }
    public class RepositorioPersonasDB : IRepositorioPersonas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("Obteniendo personas de la base de datos");
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
