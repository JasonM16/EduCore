using Domain.CourseAggregate;
using Infrastructure.CourseContext;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Infrastructure.Tests
{
    public class CourseAggregateTests
    {
        [Fact]
        public async Task Can_Add_Prerequisite_Course_To_Existing_Course()
        {
            // In-memory database only exists while the connection is open
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            try
            {
                var options = new DbContextOptionsBuilder<CourseDbContext>()                    
                    .UseSqlite(connection)
                    .Options;

                // Create the schema in the database
                using (var context = new CourseDbContext(options))
                {
                    context.Database.EnsureCreated();
                }

                // Run the test against one instance of the context
                using (var context = new CourseDbContext(options))
                {

                    var course1 = await context.Courses.FindAsync(1);
                    var course2 = await context.Courses.FindAsync(50);               
                    
                    course2.PrerequisiteCourses.Add(course1);
                    await context.SaveChangesAsync();
                }

                // Use a separate instance of the context to verify correct data was saved to database
                using (var context = new CourseDbContext(options))
                {
                    var course2 = await context.Courses
                        .Include(c => c.PrerequisiteCourses).FirstOrDefaultAsync(i => i.Id == 50);

                    Assert.Equal("4250", course2.CourseNumber);
                    Assert.Equal("1120", course2.PrerequisiteCourses.FirstOrDefault().CourseNumber);
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
