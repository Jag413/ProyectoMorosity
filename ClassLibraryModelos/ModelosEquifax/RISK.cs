using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class RISK
    {
        private string _rating;
        //Esto puede variar según el caso de personalización
        

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("idCode")]
        public string IdCode { get; set; }

        [JsonPropertyName("returnCode")]
        public string ReturnCode { get; set; }
        [JsonPropertyName("present")]
        public string Present { get; set; }
        //TODO el rating tiene varios valores autoexcluyentes, los cuales vienen dados por números
        [JsonPropertyName("rating")]
        public string Rating { get; set; }
        [JsonPropertyName("score")]
        public string Score { get; set; }
        [JsonPropertyName("araAttributes")]
        public AraAttributes AraAttributes { get; set; }
        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
    }

}
