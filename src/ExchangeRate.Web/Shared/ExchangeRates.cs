using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExchangeRate.Web.Shared
{
    public class ExchangeRates
    {
        [JsonPropertyName("provider")]
        public string? Provider { get; set; }

        [JsonPropertyName("WARNING_UPGRADE_TO_V6")]
        public string? Warning { get; set; }

        [JsonPropertyName("terms")]
        public string? Terms { get; set; }

        [JsonPropertyName("base")]
        public string? Base { get; set; }

        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        [JsonPropertyName("time_last_updated")]
        public long? TimeLastUpdated { get; set; }

        [JsonPropertyName("rates")]
        public Rate? Rates { get; set; }

    }
}
