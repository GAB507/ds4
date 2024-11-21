using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2WebAPI.Models
{
	public class Historial
	{

         
        [JsonProperty(Order = 1)]
        public int Id { get; set; }

        [JsonProperty(Order = 2)]
        public string Operacion { get; set; }

        [JsonProperty(Order = 3)]
        public string Resultado { get; set; }



    }
}