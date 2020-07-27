using System.Collections.Generic;
using Backend.Models;

namespace Backend.Contracts{
    public interface IListBuilder
    {
        List<Customer> BuildListCustomers(int n);
        List<Order> BuildListOrders(int n);
        List<Server> BuildListServers();
    }
}