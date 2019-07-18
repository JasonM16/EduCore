using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.CourseContext
{
    public class CourseContextFactory : ContextFactory<CourseDbContext>
    {
        //public CourseDbContext CreateDbContext(string[] args)
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<CourseDbContext>();

        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseContext;Integrated Security=True;MultipleActiveResultSets=True");

        //    return new CourseDbContext(optionsBuilder.Options);
        //}
    }
}
