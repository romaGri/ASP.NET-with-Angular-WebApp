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

        public CustomerHelper(IApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        private Random _rand = new Random();

        private string MakeCustomerName()
        {
            var prefix = _randomizer.GetRandom(bizPrefix);
            var suffix = _randomizer.GetRandom(bizSuffix);

            return prefix + suffix;
        }

        public Customer GetRandomCustomer()
        {
            var randomId = _rand.Next(_apiContext.Customres.Count());
            return _apiContext.Customres.First(customer => customer.Id == randomId);
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