using Backend.Contracts;
using Backend.obj.Services;
using System.Linq;

namespace Backend.Data
{
    public class DataSeed : IDataSeed
    {
        private IApiContext _apiContext;
        private IListBuilder _listBuilder;
        public DataSeed(IApiContext apiContext, IListBuilder listBuilder)
        {
            _apiContext = apiContext;
            _listBuilder = listBuilder;
        }

        public void SeedData(int nCustomers, int nOrders)
        {

            if (_apiContext.Customers.Any())
            {
                _listBuilder.BuildListCustomers(nCustomers);
                _apiContext.Save();
            }

            if (_apiContext.Orders.Any())
            {
                _listBuilder.BuildListOrders(nOrders);
                _apiContext.Save();
            }

            if (_apiContext.Servers.Any())
            {
                _listBuilder.BuildListServers();
                _apiContext.Save();
            }
        }
    }
}
