using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandlingJson.Models
{
    public class Products
    {
        [JsonProperty("id")]
        public string ID;

        [JsonProperty("Name")]
        public string NameProducts;

        [JsonProperty("Node")]
        public string NodeProducts;

        [JsonProperty("Type")]
        public string TypeProducts;
    }
}