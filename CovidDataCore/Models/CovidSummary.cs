﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidDataCore
{
    public class CovidSummary
    {
       public GlobalSummary Global { get; set; }
       public List<CountryContainer> Countries { get; set; }
    }
}
