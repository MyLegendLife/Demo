using System;
using Demo.Model.Entities.Framework;

namespace Demo.Model.Entities
{
    public class Record : EntityBase
    {
        public Record()
        {

        }

        public string Type { get; set; }

        public DateTime RecordDate { get; set; }

        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
