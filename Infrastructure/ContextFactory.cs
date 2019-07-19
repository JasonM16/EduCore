using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Infrastructure
{
    public class ContextFactory<T> : IDesignTimeDbContextFactory<T> where T : DbContext
    {
        public T CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<T>();

            if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={typeof(T).Name};Integrated Security=True;MultipleActiveResultSets=True");

            return (T)Activator.CreateInstance(typeof(T), optionsBuilder.Options);
        }
    }
}
