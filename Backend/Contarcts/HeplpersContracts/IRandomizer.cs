using System.Collections.Generic;

namespace Backend.Contracts.HelperContracts {
 public interface IRandomizer
 {  
     string GetRandom(List<string> items);
 }
} 