using Backend.Contracts;
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
            if(_apiContext.Customres.Any()){

            }
            if(_apiContext.Orders.Any()){
                
            }
            if(_apiContext.Servers.Any()){
                
            }

        }

    }
}
