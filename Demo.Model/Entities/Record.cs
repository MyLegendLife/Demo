using System;
using Demo.Model.Entities.Framework;

namespace Demo.Model.Entities
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
