using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FakeEquifax.Modelos
{
    public class Persona
    {
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("documento")]
        public string DocumentoID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("apellido")]
        public string Apellido { get; set; }
        [JsonPropertyName("hijos")]
        public List<Persona> Vastagos { get; set; }
    }

    public class InfoExtra
    {
        [JsonPropertyName("applicants")]
        public Applicants Applicants { get; set; }

    }
    
    /*
    public class Applicants
    {
        [JsonPropertyName("primaryConsumer")]
        public PrimaryConsumer PrimaryConsumer { get; set; }
    }

    public class PrimaryConsumer
    {
        [JsonPropertyName("personalInformation")]
        public PersonalInformation PersonalInformation { get; set; }
    }

    public class PersonalInformation
    {
        [JsonPropertyName("idType")]
        public string idType { get; set; }
        [JsonPropertyName("idCode")]
        public string idCode { get; set; }
        public string dateOfBirth { get; set; }


    }
    */
}