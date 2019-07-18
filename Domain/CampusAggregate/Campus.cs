using Domain.SharedKernel;
using System.Collections.Generic;

namespace Domain.CampusAggregate
{
    public class Campus : BaseEntity
    {

        public ICollection<Building> Buildings { get; set; } = new HashSet<Building>();
    }
}
