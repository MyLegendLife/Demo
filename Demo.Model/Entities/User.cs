using System;
using System.Collections.Generic;
using Demo.Model.Entities.Framework;

namespace Demo.Model.Entities
{
    public class User : EntityBase
    {
        public User()
        {
            Records = new HashSet<Record>();
        }

        public String Name { get; set; }

        public String Tel { get; set; }

        public Int32 Level { get; set; }

        //[JsonIgnore]
        public virtual ICollection<Record> Records { get; set; }
    }
}
