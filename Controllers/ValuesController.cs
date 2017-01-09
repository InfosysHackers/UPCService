using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Net.Http.Headers;

namespace PlnogramService.Controllers
{
    [Route("api")]
    public class ValuesController : Controller

    {
        [HttpGet("GetDepartment/{id}", Name = "GetDepartment")]
        public async Task<string> GetDepartment(int id)
        {
            string baseUri = "http://52.176.48.248:8000/api/getdepartment/" + id;
            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(baseUri))
                {
                    string result = await r.Content.ReadAsStringAsync();
                    return result;
                }
            }
        }

        [HttpGet("GetPlanograms/{storeNbr}/{DeptNbr}", Name = "GetPlanograms")]
        public async Task<string> GetPlanograms(int storeNbr,int DeptNbr)
        {
            string baseUri = "http://52.176.48.248:8000/api/getplanograms/" + storeNbr +"/" + DeptNbr;
            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(baseUri))
                {
                    string result = await r.Content.ReadAsStringAsync();
                    return result;
                }
            }

        }

        [HttpGet("PlanogramView/{planogramId}")]
        public async Task<string> PlanogramView(int planogramId)
        {

            string baseUri = "http://52.176.48.248:3000/" + planogramId;
            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(baseUri))
                {
                    string result = await r.Content.ReadAsStringAsync();
                    return result;
                }
            }
        }    
    }
}
