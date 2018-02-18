using System;
using System.Collections.Generic;

namespace ProjectDosApplication.Models
{
    public class CoveredIndividual : CoverageBase
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public DateTime Dob { get; set; }
        public DateTime? CoverageStartDate { get; set; }
        public DateTime? CoverageTerminationDate { get; set; }
        public int RecipientId { get; set; }
        public Recipient Recipient { get; set; }

        public List<CoverageInformation> CoverageInformations
        {
            get; set;

        }
    }
}