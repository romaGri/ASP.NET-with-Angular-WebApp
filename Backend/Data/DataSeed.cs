using Backend.Contracts;
using Backend.obj.Services;
using System.Linq;

namespace Backend.Data
{
    public class DataSeed
    {
        private IApiContext _apiContext;
        public DataSeed(IApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        public void SeedData(int nCustomers, int nOrders, int nservers)
        {
            if (_apiContext.Customres.Any())
            {
                _apiContext.Save();
            }
            
            if (_apiContext.Orders.Any())
            {
                _apiContext.Save();
            }

            if (_apiContext.Servers.Any())
            {
                _apiContext.Save();
            }

        }

    }
}
