using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class PrimaryConsumer
    {

        [JsonPropertyName("personalInformation")]
        public PersonalInformation PersonalInformation { get; set; }

        [JsonPropertyName("dataSourceResponses")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DataSourceResponses DataSourceResponses { get; set; }
    }
}
