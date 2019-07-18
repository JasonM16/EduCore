using Domain.SharedKernel;
using System.Collections.Generic;

namespace Domain.CourseAggregate
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public string DepartmentName { get; set; }
        public string CourseNumber { get; set; }
        public ICollection<Prerequisite> PrerequisiteCourses { get; set; } = new HashSet<Prerequisite>();
    }
}