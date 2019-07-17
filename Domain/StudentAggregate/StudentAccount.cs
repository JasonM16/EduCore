using Domain.SharedKernel;
using System;
using System.Collections.Generic;

namespace Domain.StudentAggregate
{
    public class StudentAccount : BaseEntity
    {
        // Major
        // Student Since
        // Academic Standing
        // Arrears
        // 
        public DateTime? EnrollmentDate { get; set; }
        //public int StudentId { get; set; }
        //public Student Student { get; set; }
        //public int CartId { get; set; }
        //public Cart Cart { get; set; }
        //public int ContactDetailsId { get; set; }
        //public ContactDetails ContactDetails { get; set; }
        public ICollection<CurrentStudentSchedule> Schedules { get; set; } // name it Enrollments??
        //public virtual ICollection<Program> Programs { get; set; }
        public AcademicRecord AcademicRecord { get; set; }
    }
}