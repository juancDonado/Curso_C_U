using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace PrincipiosSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class ProcesadorDeTareas
    {
        private readonly LoggerConsola logger;
        private readonly RepositorioTareas repositorioTareas;
        public ProcesadorDeTareas(LoggerConsola logger,
            RepositorioTareas repositorioTareas)
        {
            this.logger = logger;
            this.repositorioTareas = repositorioTareas;
        }

        public async Task Procesar()
        {
            try
            {
                logger.Log("Inicio de proceso0");

                var tareas = repositorioTareas.ObtenerTareas();
                var tareasNoRealizadas = tareas.Where(x => !x.completed).ToList();

                var urlUsuarios = "https://jsonplaceholder.typicode.com/users";
                var respuestaUsuarios = await client.GetAsync(urlUsuarios);
                respuestaUsuarios.EnsureSuccessStatusCode();
                var cuerpoRespuestaUsuarios = await respuestaUsuarios.Content.ReadAsStringAsync();
                logger.Log(cuerpoRespuestaUsuarios);
                var usuarios = JsonConvert.DeserializeObject<Usuario[]>(cuerpoRespuestaUsuarios);

                logger.Log("Inicio transformacion a ViewModel");
                var tareasViewModel = new List<TareaViewModel>();
                foreach (var tarea in tareasNoRealizadas)
                {
                    var tareaViewModel = new TareaViewModel()
                    {
                        Id = tarea.Id,
                        Title = tarea.Title.Trim(),
                        NombreUsuario = usuarios.Where(x => x.Id == tarea.UserId).First().Name.Trim()
                    };
                    tareasViewModel.Add(tareaViewModel);
                }
                logger.Log("Inicio de escritura de tareas en archivo");
                using (StreamWriter writetext = new StreamWriter($@"{Directory.GetCurrentDirectory()}\tareas_pendientes.txt"))
                {
                    foreach (var tarea in tareasViewModel)
                    {
                        writetext.WriteLine($"{DateTime.Now.ToString().PadRight(25)}{tarea.Id.ToString().PadRight(10)}{tarea.NombreUsuario.PadRight(30)}{tarea.Title}");
                    }
                }
            }
            catch (Exception err)
            {
                logger.LogException(err);
            }
        }
    }
}
