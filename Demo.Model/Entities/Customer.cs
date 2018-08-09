using System;
using System.Collections.Generic;
using Demo.Model.Entities.Framework;
using Newtonsoft.Json;

namespace Demo.Model.Entities
{
    public class Customer : EntityBase
    {
        public Customer()
        {
            Records = new HashSet<Record>();
        }

        public String Name { get; set; }

        public String Tel { get; set; }

        public Int32 Level { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
