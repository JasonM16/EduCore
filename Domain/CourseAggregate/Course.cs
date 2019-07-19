using Domain.SharedKernel;
using System.Collections.Generic;

namespace Domain.CourseAggregate
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public string DepartmentCode { get; set; }        
        public string CourseDescription { get; set; }
        public int Credits { get; set; }
        public ICollection<Course> PrerequisiteCourses { get; set; } = new HashSet<Course>();
    }
}