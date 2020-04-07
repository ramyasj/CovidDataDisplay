using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceRepo.Models;
using Core.CovidDataLayer;

namespace ServiceRepo.Controllers
{
    [Route("[controller]")]
    [ApiController]   
    public class CovidDataServiceController : ControllerBase
    {
        [HttpGet]
        public async Task<CovidSummary> getCovidDataApi() {

            return await GetCovidData.GetData();
        }

    }
}