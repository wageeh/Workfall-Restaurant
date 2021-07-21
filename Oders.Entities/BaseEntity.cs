using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Enitites
{
    public class BaseEntity
    {

        [JsonProperty(PropertyName = "id")]
        public Guid EntityId { get; set; }
        public string ItemId { get; set; }

        [JsonProperty(PropertyName = "createddate")]
        public DateTime CreatedDate { get; set; }

    }
}
