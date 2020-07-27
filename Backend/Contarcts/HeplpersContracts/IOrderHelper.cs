using System;

namespace Backend.Contracts.HelperContracts{
    public interface IOrderHelper
    {
        DateTime GetRandOrderPlaced();
        DateTime? GetRandOrderComplited(DateTime placed);
        decimal GetRandOrderTotal();
    }
}