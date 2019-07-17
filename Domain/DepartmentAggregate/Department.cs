using Domain.DepartmentAggregate.Faculty;
using System.Collections.Generic;

namespace Domain.DepartmentAggregate
{
    public class Department
    {
        public Department()
        {
            Professors = new HashSet<Professor>();
            Programs = new HashSet<Program>();
            Courses = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string FacultyOf { get; set; }
        public int FacultyId { get; set; }
        public int DepartmentNumber { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
