using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceRepo.Models
{
    public class CountryContainer :GlobalSummary
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }        
    }
}
