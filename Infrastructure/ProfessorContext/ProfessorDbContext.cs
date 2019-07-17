using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ProfessorContext
{
    class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext(DbContextOptions options) : base(options)
        { }



    }
}
