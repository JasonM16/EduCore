namespace Domain.DepartmentAggregate
{
    public class Program
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string Description { get; set; }
        public int NumberOfCourses { get; set; }
        public string Requirements { get; set; }
        public bool Coop { get; set; }
        public string DegreeType { get; set; }
        //public Professor Chair { get; set; }
        public int? MaxNumberFirstYearStudents { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
