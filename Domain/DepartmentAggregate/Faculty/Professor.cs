using System.Collections.Generic;

namespace Domain.DepartmentAggregate.Faculty
{
    public class Professor
    {
        public Professor()
        {
            //Departments = new HashSet<Department>();
            //CourseDetails = new HashSet<Details>();
            Publications = new HashSet<string>();
        }
        public int ProfessorId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Profile { get; set; }
        public ContactDetails ContactInformation { get; set; }
        //public ICollection<Department> Departments { get; set; }
        //public ICollection<Details> CourseDetails { get; set; }
        public ICollection<string> Publications { get; set; } // create type??
        public string ResearchInterests { get; set; }
    }
}
