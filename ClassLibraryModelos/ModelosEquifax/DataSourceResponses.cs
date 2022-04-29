using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class DataSourceResponses
    {
        [JsonPropertyName("EIPG")]
        public EIPG EIPG { get; set; }

        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
    }
}
