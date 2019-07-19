using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.SharedKernel
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        [NotMapped]
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
