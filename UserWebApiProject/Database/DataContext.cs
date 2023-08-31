using Microsoft.EntityFrameworkCore;
using UserWebApiProject.Entities;

namespace UserWebApiProject.Database
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Users tablosu...
        public DbSet<User> Users { get; set; }

    }
}
