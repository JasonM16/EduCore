using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.StudentAccountContext
{
    class StudentAccountDbContext : DbContext
    {
        public StudentAccountDbContext(DbContextOptions options) : base(options)
        { }
    }
}
