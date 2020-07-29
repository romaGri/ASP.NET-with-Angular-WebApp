using System.Collections.Generic;
using Backend.Models;
using Backend.Contracts;
using Backend.Contracts.HelperContracts;

namespace Backend.Data{
    public class ListBuilder : IListBuilder
    {
        private IRandomizer _rand;
        private ICustomerHelper _customerHеlper; 
        private IOrderHelper _orderHеlper;

        public ListBuilder(IRandomizer rand, ICustomerHelper customerHеlper, IOrderHelper orderHеlper)
        {
            _rand =rand;
            _customerHеlper = customerHеlper;
            _orderHеlper = orderHеlper; 
        }
        public List<Customer> BuildListCustomers(int n)
        {
            var customres = new List<Customer>();

            for (int i = 1; i < n; i++)
            {
                var name = _customerHеlper.MakeCustomerName();

                customres.Add(
                    new Customer{
                        Id = i,
                        Name = name,
                        State = _rand.GetRandom(_customerHеlper.getStates()),
                        Email = _customerHеlper.MakeCustomerEmail(name)
                    }
                );
            }

            return customres;
        }

        public List<Order> BuildListOrders(int n)
        {
            var orders = new List<Order>();

            var placed = _orderHеlper.GetRandOrderPlaced();
            var completed = _orderHеlper.GetRandOrderComplited(placed);

            for (int i = 1; i < n; i++)
            {
                orders.Add(new Order(){
                    Id = i,
                    Customer = _customerHеlper.GetRandomCustomer(),
                    Total = _orderHеlper.GetRandOrderTotal(),
                    Placed = placed,
                    Completed = completed
                });
            }

            return orders;
        }

        public List<Server> BuildListServers()
        {
            return new List<Server>(){
               new Server
                {
                    Id = 1,
                    Name = "Dev-Web",
                    IsEnabled = true
                },

                new Server
                {
                    Id = 2,
                    Name = "Dev-Analysis",
                    IsEnabled = true
                },

                new Server
                {
                    Id = 3,
                    Name = "Dev-Mail",
                    IsEnabled = true
                },

                new Server
                {
                    Id = 4,
                    Name = "QA-Web",
                    IsEnabled = true
                },

                new Server
                {
                    Id = 5,
                    Name = "QA-Analysis",
                    IsEnabled = true
                },

                new Server
                {
                    Id = 6,
                    Name = "QA-Mail",
                    IsEnabled = true
                },

                new Server
                {
                    Id = 7,
                    Name = "Prod-Web",
                    IsEnabled = true
                },

                new Server
                {
                    Id = 8,
                    Name = "Prod-Analysis",
                    IsEnabled = true
                },

                new Server
                {
                    Id = 9,
                    Name = "Prod-Mail",
                    IsEnabled = true
                },
            };
        }
    }
}