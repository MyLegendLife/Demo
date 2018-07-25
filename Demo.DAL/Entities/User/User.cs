using Demo.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities.User
{
    public class User : EntityBase
    {
        public User()
        {
            this.Records = new HashSet<Record>();
        }

        public String Name { get; set; }

        public String Tel { get; set; }

        public Int32 Level { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
