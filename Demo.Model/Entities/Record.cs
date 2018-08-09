using System;
using Demo.Model.Entities.Framework;
using Newtonsoft.Json;

namespace Demo.Model.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    //[JsonObject(MemberSerialization.OptIn)]
    public class Record : EntityBase
    {
        public Record()
        {

        }

        [JsonProperty]
        public string Type { get; set; }

        public DateTime RecordDate { get; set; }

        public Guid CustomerId { get; set; }

        //[JsonIgnore]
        public virtual Customer Customer { get; set; }
    }
}
