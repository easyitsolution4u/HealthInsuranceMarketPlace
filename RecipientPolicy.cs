using System;

namespace ProjectDosApplication.Models
{
    public class RecipientPolicy : CoverageBase
    {
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyTerminationDate { get; set; }
        public int RecipientId { get; set; }
        public Recipient Recipient { get; set; }

    }
}