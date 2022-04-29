using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class EIPG
    {
        [JsonPropertyName("ASNEFDETAIL")]
        public ASNEFDETAIL ASNEFDETAIL { get; set; }
        [JsonPropertyName("RISK")]
        public RISK RISK { get; set; }
    }
}
