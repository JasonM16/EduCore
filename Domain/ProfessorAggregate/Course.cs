using Domain.SharedKernel;
using System.Collections.Generic;

namespace Domain.ProfessorAggregate
{
    public class Course : BaseEntity
    {
        public ICollection<Evaluations> Evaluations { get; set; }

    }

}