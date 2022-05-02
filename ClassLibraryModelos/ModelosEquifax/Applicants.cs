using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class Applicants
    {
        [JsonPropertyName("primaryConsumer")]
        public PrimaryConsumer PrimaryConsumer { get; set; }
    }
}
