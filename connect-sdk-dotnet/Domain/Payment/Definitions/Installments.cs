/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Installments
    {
        public AmountOfMoney AmountOfMoneyPerInstallment { get; set; } = null;

        public string FrequencyOfInstallments { get; set; } = null;

        public string InterestRate { get; set; } = null;

        public long? NumberOfInstallments { get; set; } = null;
    }
}
