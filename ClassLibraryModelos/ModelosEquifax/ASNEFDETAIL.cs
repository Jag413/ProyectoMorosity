using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class ASNEFDETAIL
    {

        private const string IS_ASNEF = "000";
        private const string ISNOT_ASNEF = "001";
        private const string _returncode;

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("idCode")]
        public string IdCode { get; set; }

        [JsonPropertyName("returnCode")]
        public string ReturnCode
        {
            get
            {
                if (SummaryInformation is null)
                {
                    return _returncode = ISNOT_ASNEF;
                }
                else
                {
                    return _returncode = IS_ASNEF;
                }
            }
            set => _returncode = value;
        }

        [JsonPropertyName("summaryInformation")]
        public SummaryInformation SummaryInformation { get; set; }

        [JsonPropertyName("MonthlyCreditInformation")]
        public List<MonthlyCreditInformation> MonthlyCreditInformation { get; set; }

        [JsonPropertyName("creditOperations")]
        public List<CreditOperation> CreditOperations { get; set; }

        [JsonPropertyName("specificCreditOperationsDetails")]
        public List<SpecificCreditOperationsDetails> SpecificCreditOperationsDetails { get; set; }
    }
}
