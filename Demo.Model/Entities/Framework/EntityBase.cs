using System;

namespace Demo.Model.Entities.Framework
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            CreatedTime = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public bool IsNew => Id == Guid.Empty;

        public void NewId()
        {
            Id = Guid.NewGuid();
        }
    }
}
