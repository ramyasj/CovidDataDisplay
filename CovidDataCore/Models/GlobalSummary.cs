using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidDataCore
{
    public class GlobalSummary
    {
        public int NewConfirmed { get; set; }
        public string TotalConfirmed { get; set; }
        public string NewDeaths { get; set; }
        public string TotalDeaths { get; set; }
        public string NewRecoverd { get; set; }
        public string TotalRecovered { get; set; }
        public DateTime date { get; set; }
    }
}
