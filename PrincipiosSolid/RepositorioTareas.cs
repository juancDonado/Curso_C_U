﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid
{
    public class RepositorioTareas
    {
        private readonly LoggerConsola logger;
        public RepositorioTareas(LoggerConsola logger)
        {
            this.logger = logger;
        }
        public async Task<List<Tarea>> ObtenerTareas()
        {
            var client = new HttpClient();
            var urlTareas = "https://jsonplaceholder.typicode.com/todos";
            var respuestaTareas = await client.GetAsync(urlTareas);
            respuestaTareas.EnsureSuccessStatusCode();
            var cuerpoRespuestaTareas = await respuestaTareas.Content.ReadAsStringAsync();
            logger.Log(cuerpoRespuestaTareas);

            var tareas = JsonConvert.DeserializeObject<List<Tarea>>(cuerpoRespuestaTareas);

            return tareas;
        }
    }
}
