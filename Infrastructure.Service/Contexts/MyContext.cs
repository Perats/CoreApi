using Infrastructure.Interface.Models;
using Infrastructure.Service.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Service.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Device> Device { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            base.OnModelCreating(modelBuilder
                .ApplyConfiguration(new UserConfiguration())
                );
    }
}
