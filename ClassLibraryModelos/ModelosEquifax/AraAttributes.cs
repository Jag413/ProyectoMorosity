using System.Text.Json.Serialization;

namespace ClassLibraryModelos.ModelosEquifax
{
    


    public class AraAttributes
    {
        [JsonPropertyName("totalNumberOfOperations")]
        public int TotalNumberOfOperations { get; set; }
        [JsonPropertyName("numberOfConsumerCreditOperations")]
        public int NumberOfConsumerCreditOperations { get; set; }
        [JsonPropertyName("numberOfMortgageOperations")]
        public int NumberOfMortgageOperations { get; set; }
        [JsonPropertyName("numberOfPersonalLoanOperations")]
        public int NumberOfPersonalLoanOperations { get; set; }
        [JsonPropertyName("numberOfCreditCardOperations")]
        public int NumberOfCreditCardOperations { get; set; }
        [JsonPropertyName("numberOfTelcoOperations")]
        public int NumberOfTelcoOperations { get; set; }
        [JsonPropertyName("totalNumberOfOtherUnpaid")]
        public int TotalNumberOfOtherUnpaid { get; set; }
        [JsonPropertyName("totalUnpaidBalance")]
        public double TotalUnpaidBalance { get; set; }
        [JsonPropertyName("unpaidBalanceOwnEntity")]
        public int UnpaidBalanceOwnEntity { get; set; }
        [JsonPropertyName("unpaidBalanceOfOtherEntities")]
        public double UnpaidBalanceOfOtherEntities { get; set; }
        [JsonPropertyName("unpaidBalanceOfConsumerCredit")]
        public int UnpaidBalanceOfConsumerCredit { get; set; }
        [JsonPropertyName("unpaidBalanceOfMortgage")]
        public int UnpaidBalanceOfMortgage { get; set; }
        [JsonPropertyName("unpaidBalanceOfPersonalLoan")]
        public double UnpaidBalanceOfPersonalLoan { get; set; }
        [JsonPropertyName("unpaidBalanceOfCreditCard")]
        public int UnpaidBalanceOfCreditCard { get; set; }
        [JsonPropertyName("unpaidBalanceOfTelco")]
        public int UnpaidBalanceOfTelco { get; set; }
        [JsonPropertyName("unpaidBalanceOfOtherProducts")]
        public int UnpaidBalanceOfOtherProducts { get; set; }
        [JsonPropertyName("worstUnpaidBalance")]
        public double WorstUnpaidBalance { get; set; }
        [JsonPropertyName("worstSituationCode")]
        public string WorstSituationCode { get; set; }
        [JsonPropertyName("numberOfDaysOfWorstSituation")]
        public int NumberOfDaysOfWorstSituation { get; set; }
        [JsonPropertyName("numberOfCreditors")]
        public int NumberOfCreditors { get; set; }
        [JsonPropertyName("delincuencyDays")]
        public int DelincuencyDays { get; set; }
    }

}