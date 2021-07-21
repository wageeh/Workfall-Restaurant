using Newtonsoft.Json;
using Orders.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oders.Entities
{
    public class Order:BaseEntity
    {
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }


        public string Name { get; set; }
    }
}
