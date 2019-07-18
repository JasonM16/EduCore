using Domain.SharedKernel;

namespace Domain.CourseAggregate
{
    public class Prerequisite : BaseEntity
    {
        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}
