using Domain.SharedKernel;
using System.Collections.Generic;

namespace Domain.StudentAggregate
{
    public class AcademicRecord : BaseEntity
    {
        public int AcademicRecordId { get; set; }

        // acdemic standing
        // Declared Major

        

        public virtual ICollection<PreviousCourse> PreviousCourses { get; set; }
    }

    public class PreviousCourse
    {
        public int PreviousCourseId { get; set; }
        public int CourseId { get; set; }
        public Grade Grade { get; set; }
    }

    public enum Grade
    {

    }
}
