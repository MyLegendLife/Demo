using Demo.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities.User
{
    public class Record : EntityBase
    {
        public Record()
        {

        }

        public String Type { get; set; }

        public DateTime RecordDate { get; set; }

        public String UserId { get; set; }

        public virtual User User { get; set; }
    }

    
}
