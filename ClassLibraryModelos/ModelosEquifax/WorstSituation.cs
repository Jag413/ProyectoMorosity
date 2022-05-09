using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class WorstSituation
    {
       
        //TODO Estos son los codigos de worsSituation los dejo aquí o en un diccionario a parte
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
