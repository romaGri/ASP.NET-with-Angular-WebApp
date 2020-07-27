using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Contracts {
    public interface IApiContext
    {   
         DbSet<Order> Orders { get; set; }
         DbSet<Customer> Customres { get; set; }
         DbSet<Server> Servers { get; set; }

         void Save();
    }
}