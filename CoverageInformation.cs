namespace ProjectDosApplication.Models
{
    public class CoverageInformation : CoverageBase
    {
        public string Month { get; set; }
        public decimal MonthlyEnrollmentPremium { get; set; }
        public decimal MonthlySecondLowestCostSilverPremium { get; set; }
        public decimal MonthyAdvancedPaymentPremium { get; set; }
        public int CoveredIndividualId { get; set; }
        public CoveredIndividual CoveredIndividual { get; set; }
    }
}