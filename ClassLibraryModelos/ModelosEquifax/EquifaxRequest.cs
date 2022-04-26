using System.Text.Json.Serialization;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class EquifaxRequest
    {
        [JsonPropertyName("applicants")]
        public Applicants Applicants { get; set; }

        public bool IsValidToSerializeBasicEquifax()
        {
            return Applicants.PrimaryConsumer.PersonalInformation.IdType != null &&
                   Applicants.PrimaryConsumer.PersonalInformation.IdCode != null;
        }
        
        public bool IsValidToSerializeAmpliadoEquifax()
        {
            return IsValidToSerializeBasicEquifax() &&
                   Applicants.PrimaryConsumer.PersonalInformation.Addresses != null &&
                   Applicants.PrimaryConsumer.PersonalInformation.Addresses.Count > 0;
        }
    }
}