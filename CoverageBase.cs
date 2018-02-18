using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDosApplication.Models
{
    public abstract class CoverageBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActiveRecord { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public string DeactivatedBy { get; set; }
    }
}