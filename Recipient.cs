using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDosApplication.Models
{


    public class Recipient : CoverageBase
    {
        public string MarketPlaceIdentifier { get; set; }
        public string MarketPlaceAssignedPolicyNumber { get; set; }
        public string PolicyIssuerName { get; set; }
        public string RecipientFirstName { get; set; }
        public string RecipientMiddleName { get; set; }
        public string RecipientLastName { get; set; }
        public string RecipientFirstSSN { get; set; }
        public DateTime RecipientDob { get; set; }

        public string RecipientSpouseFirstName { get; set; }
        public string RecipientSpouseMiddleName { get; set; }
        public string RecipientSpouseLastName { get; set; }
        public string RecipientSpouseSSN { get; set; }
        public DateTime RecipientSpouseDob { get; set; }
        public List<RecipientPolicy> RecipientPolicies { get; set; }
        public Address RecipientAddress { get; set; }
        public List<CoveredIndividual> CoveredIndividuals { get; set; }
        

    }
}