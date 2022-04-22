using System.Text.Json.Serialization;

namespace FakeEquifax.Modelos
{
    public class Persona
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("documento")]
        public string DocumentoID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("apellido")]
        public string Apellido { get; set; }
        
    }
}