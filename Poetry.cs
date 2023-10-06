using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiConnection
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Poetry>>(myJsonResponse);
    public class Poetry
    {
        [JsonProperty("lines")]
        public List<string> Lines;
    }


}
