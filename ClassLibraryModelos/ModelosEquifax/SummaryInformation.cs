using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class SummaryInformation
    {
        [JsonPropertyName("personName")]
        public string PersonName { get; set; }

        [JsonPropertyName("identificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonPropertyName("originalCreatedDate")]
        public string OriginalCreatedDate { get; set; }

        [JsonPropertyName("mostRecentUpdateDate")]
        public string MostRecentUpdateDate { get; set; }

        [JsonPropertyName("recentInquiryEntity")]
        public string RecentInquiryEntity { get; set; }

        [JsonPropertyName("numberOfOperations")]
        public int NumberOfOperations { get; set; }

        [JsonPropertyName("totalAmountOfOperations")]
        public double TotalAmountOfOperations { get; set; }

        [JsonPropertyName("numberOfUnpaidOperations")]
        public int NumberOfUnpaidOperations { get; set; }

        [JsonPropertyName("numberOfUnpaidPayments")]
        public int NumberOfUnpaidPayments { get; set; }

        [JsonPropertyName("totalUnpaidPaymentAmount")]
        public double TotalUnpaidPaymentAmount { get; set; }

        [JsonPropertyName("maximumUnpaidPaymentAmount")]
        public double MaximumUnpaidPaymentAmount { get; set; }

        [JsonPropertyName("maximumUnpaidPaymentDate")]
        public string MaximumUnpaidPaymentDate { get; set; }

        [JsonPropertyName("worstSituation")]
        public WorstSituation WorstSituation { get; set; }

        [JsonPropertyName("worstSituationDate")]
        public string WorstSituationDate { get; set; }
    }
}
