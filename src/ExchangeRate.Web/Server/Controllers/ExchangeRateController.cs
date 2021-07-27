using ExchangeRate.Web.Client.Pages;
using ExchangeRate.Web.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExchangeRate.Web.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangeRateController : ControllerBase
    {
        private const string APIURL = "https://api.exchangerate-api.com/v4/latest/";

        private readonly ILogger<ExchangeRateController> _logger;

        public ExchangeRateController(ILogger<ExchangeRateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [HttpGet("{countryCode}")]
        public async Task<ExchangeRates> Get(string countryCode = "USD")
        {
            // call api
            using (var client = new HttpClient())
            {
                StringBuilder apiWithCountryCode = new StringBuilder();
                apiWithCountryCode.Append(APIURL);
                apiWithCountryCode.Append(countryCode);

                HttpResponseMessage response = await client.GetAsync(apiWithCountryCode.ToString());

                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // deserialize json into exchange rate
                    var rates = JsonSerializer.Deserialize<ExchangeRates>(responseBody);

                    // return exchange rate
                    return rates;
                }
            }
        }
    }
}
