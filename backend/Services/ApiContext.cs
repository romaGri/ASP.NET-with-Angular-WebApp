using Backend.Contracts;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.obj.Services
{
    public class ApiContext : DbContext, IApiContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Server> Servers { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}