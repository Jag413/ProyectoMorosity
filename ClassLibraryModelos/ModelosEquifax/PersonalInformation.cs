using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class PersonalInformation
    {

        private string _idType?;
        private string _idCode;
        private const string IDCODE_DEFAULT = "00000000";
        private enum IdTypes { ID, PASS, NA }


        [JsonPropertyName("idCountryCode")]
        public string IdCountryCode { get; set; }

        [JsonPropertyName("idType")]
        public string IdType
        {
            //TODO Comprobar codigo get set, con la info pdf
            get
            {
                if (!String.IsNullOrEmpty(IdAuxiliar) && !String.IsNullOrEmpty(CorrelationId))
                {
                    if (!(!_idType.ToUpper().Equals(IdTypes.ID) || !_idType.ToUpper().Equals(IdTypes.PASS) || !_idType.ToUpper().Equals(IdTypes.NA))) { return _idType.ToUpper(); }
                    else { return null }  
                }
                else
                {
                    return null;
                }
            }
            set => _idType = value;
        }

        [JsonPropertyName("idCode")]
        public string IdCode
        {
            get
            {
                if (String.IsNullOrEmpty(IdAuxiliar) && String.IsNullOrEmpty(CorrelationId))
                {
                    return _idCode.ToUpper();
                }
                else
                {
                    return IDCODE_DEFAULT;
                }
            }
            set => _idCode = value;
        }
        [JsonPropertyName("idAuxiliar")]
        public string IdAuxiliar { get; set; }
        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }
        [JsonPropertyName("dateOfBirth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DateOfBirth { get; set; }

        [JsonPropertyName("addresses")]
        public List<Address> Addresses { get; set; }
        
    }
}
