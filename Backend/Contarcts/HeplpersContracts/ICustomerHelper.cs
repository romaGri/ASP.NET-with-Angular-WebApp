using Backend.Models;

namespace Backend.Contracts.HelperContracts{
    public interface ICustomerHelper
    {
        Customer GetRandomCustomer();
    }
}