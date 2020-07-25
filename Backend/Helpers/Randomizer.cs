using System;
using System.Collections.Generic;
using Backend.Contracts.HelperContracts;

namespace Backend.Helpers{
    public class Randomizer : IRandomizer {
        private  Random _rand = new Random();
        public string GetRandom(List<string> items){
            return items[_rand.Next(items.Count)];
        }
    }
}