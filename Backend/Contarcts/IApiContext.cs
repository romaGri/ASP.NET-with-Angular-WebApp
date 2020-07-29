using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Contracts {
    public interface IApiContext
    {   
         DbSet<Order> Orders { get; set; }
         DbSet<Customer> Customers { get; set; }
         DbSet<Server> Servers { get; set; }

         void Save();
    }
}