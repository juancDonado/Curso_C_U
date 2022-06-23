using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO_9
{
    public class RepositorioResultadoTareasViewModel
    {
        public void Guardar(List<TareaViewModel> tareas)
        {
            using (StreamWriter writetext = new StreamWriter($@"{Directory.GetCurrentDirectory()}\tareas_pendientes.txt"))
            {
                foreach (var tarea in tareas)
                {
                    writetext.WriteLine($"{DateTime.Now.ToString().PadRight(25)}{tarea.Id.ToString().PadRight(10)}{tarea.NombreUsuario.PadRight(30)}{tarea.Title}");
                }
            }
        }
    }
}
