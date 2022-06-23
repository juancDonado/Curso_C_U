using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO_9
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<ILog>(x => new FactorialLoggers().ObtenerLogger("consola"))
                .AddTransient<RepositorioTareas>()
                .AddTransient<RepositorioUsuarios>()
                .AddTransient<Mapeador>()
                .AddTransient<RepositorioResultadoTareasViewModel>()
                .AddTransient<ProcesadorDeTareas>()
                .BuildServiceProvider();

            var procesadorTareas = serviceProvider.GetService<ProcesadorDeTareas>();
            await procesadorTareas.Procesar();
        }
    }
    public class ProcesadorDeTareas
    {
        private readonly ILog logger;
        private readonly RepositorioTareas repositorioTareas;
        private readonly RepositorioUsuarios repositorioUsuarios;
        private readonly Mapeador mapeador;
        private readonly RepositorioResultadoTareasViewModel repResTareasVM;
        public ProcesadorDeTareas(ILog logger,
            RepositorioTareas repositorioTareas,
            RepositorioUsuarios repositorioUsuarios,
            Mapeador mapeador,
            RepositorioResultadoTareasViewModel repResTareasVM)
        {
            this.logger = logger;
            this.repositorioTareas = repositorioTareas;
            this.repositorioUsuarios = repositorioUsuarios;
            this.mapeador = mapeador;
            this.repResTareasVM = repResTareasVM;
        }

        public async Task Procesar()
        {
            try
            {
                logger.Log("Inicio de proceso0");

                var tareas = await repositorioTareas.ObtenerTareas();
                var tareasNoRealizadas = tareas.Where(x => !x.Completed).ToList();
                var usuarios = await repositorioUsuarios.ObtenerUsuarios();

                logger.Log("Inicio transformacion a ViewModel");
                var tareasViewModel = mapeador.Mapear(tareasNoRealizadas, usuarios);

                logger.Log("Inicio de escritura de tareas en archivo");
                repResTareasVM.Guardar(tareasViewModel);
            }
            catch(Exception err)
            {
                logger.LogException(err);
            }
        }
    }
}
