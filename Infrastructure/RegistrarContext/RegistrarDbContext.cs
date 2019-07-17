using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.RegistrarContext
{
    class RegistrarDbContext : DbContext
    {
        public RegistrarDbContext(DbContextOptions options) : base(options)
        { }
    }
}
