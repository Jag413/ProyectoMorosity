using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class Situation
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string DescriptionEn { get; set; }
        public string DescriptionEs { get; set; }
    }
}
