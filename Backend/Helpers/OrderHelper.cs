using System;
using Backend.Contracts.HelperContracts;

namespace Backend.Helpers
{
    public class OrderHelper : IOrderHelper
    {
        private Random _rand;

        public DateTime? GetRandOrderComplited(DateTime placed)
        {
            var now = DateTime.Now;
            var minLeadTime = TimeSpan.FromDays(7);
            var timePassed = now - placed;

            if (timePassed < minLeadTime)
            {
                return null;
            }

            return placed.AddHours(_rand.Next(10, 90));
        }

        public DateTime GetRandOrderPlaced()
        {
            var end = DateTime.Now;

            var start = end.AddDays(-90);

            TimeSpan possibleSpan = start - end;
            TimeSpan newSpan = new TimeSpan(0, _rand.Next(0, (int)possibleSpan.TotalMinutes), 0);

            return start + newSpan;
        }

        public decimal GetRandOrderTotal()
        {
            return _rand.Next(25, 1000);
        }
    }
}