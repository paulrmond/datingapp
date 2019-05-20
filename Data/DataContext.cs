using Microsoft.EntityFrameworkCore;
using DatingApp.API.Model;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values {get;set;}
        public DbSet<Employee> Employees{get;set;}
    }
}