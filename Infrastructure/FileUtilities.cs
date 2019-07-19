using CsvHelper;
using Domain.CourseAggregate;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Infrastructure
{
    public class FileUtilities
    {   
        public static IEnumerable<Course> ParseFile()
        {
            var dir = Directory.GetCurrentDirectory();
            string filePath = Path.GetFullPath(Path.Combine(dir, @"C:\Dev\EduCore\Repo\Infrastructure\Courses.csv"));
            IEnumerable<Course> courses = new List<Course>();
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader))
            {
                courses = csv.GetRecords<Course>().ToList();
            }
            
            Course course = new Course();
            

            return courses.ToList();
        }
    }
}
