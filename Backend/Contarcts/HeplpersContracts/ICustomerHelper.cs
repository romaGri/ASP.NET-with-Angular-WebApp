using System.Collections.Generic;
using Backend.Models;

namespace Backend.Contracts.HelperContracts{
    public interface ICustomerHelper
    {
        Customer GetRandomCustomer();
        string MakeCustomerName();
        string MakeCustomerEmail(string name);

        List<string> getStates();
       
    }
}