using Domain.SharedKernel;
using System.Collections.Generic;

namespace Domain.StudentAggregate
{
    public class CurrentStudentSchedule : BaseEntity
    {  
        public string Semester { get; set; }
        public int Year { get; set; }        
        public int StudentAccountId { get; set; }
        public StudentAccount Student { get; set; }
        public ICollection<CurrentStudentCourse> Courses { get; set; }
    }
}