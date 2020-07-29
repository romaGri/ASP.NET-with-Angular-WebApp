using System;
using System.Collections.Generic;
using System.Linq;
using Backend.Contracts;
using Backend.Contracts.HelperContracts;
using Backend.Models;

namespace Backend.Helpers
{
    public class CustomerHelper : ICustomerHelper
    {
        private readonly IRandomizer _randomizer;
        private readonly IApiContext _apiContext;

        public CustomerHelper(IApiContext apiContext, IRandomizer randomizer) 
        {
            _apiContext = apiContext;
            _randomizer = randomizer;
        }

        private Random _rand = new Random();

        public Customer GetRandomCustomer()
        {
            var randomId = _rand.Next(_apiContext.Customers.Count());
            return _apiContext.Customers.First(customer => customer.Id == randomId);
        }

        public string MakeCustomerName()
        {
            var prefix = _randomizer.GetRandom(bizPrefix);
            var suffix = _randomizer.GetRandom(bizSuffix);

            return prefix + suffix;
        }

        public string MakeCustomerEmail(string name)
        {
            return $"contact@{name.ToLower()}_{DateTime.Now:fff}.com";
        }

        public List<string> getStates()
        {
            var states = new List<string>(){
            "AK", "AL","AZ",  "AR", "CA", "CO", "CT", "DE", "FL", "GA",
            "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
            "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
            "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
            "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
            };
            
            return states;
        }

        private readonly List<string> bizPrefix = new List<string>()
        {
            "ABC",
            "XYZ",
            "Acme",
            "MainSt",
            "Ready",
            "Magic",
            "Fluent",
            "Peak",
            "Forward",
            "Enterprise",
            "Sales"
        };

        private readonly List<string> bizSuffix = new List<string>()
        {
            "Co",
            "Corp",
            "Holdings",
            "Corporation",
            "Movers",
            "Cleaners",
            "Bakery",
            "Apparel",
            "Rentals",
            "Storage",
            "Transit",
            "Logistics"
        };

    }
}