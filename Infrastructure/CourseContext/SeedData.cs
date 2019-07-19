using Domain.CourseAggregate;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Infrastructure.CourseContext
{
    public class SeedData
    {
        public static IEnumerable<Course> GetCourseData() => FileUtilities.ParseFile();
    }

    
}
