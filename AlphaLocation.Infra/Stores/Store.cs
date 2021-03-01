using AlphaLocation.Customers.Infra.Entities;
using JsonFlatFileDataStore;

namespace AlphaLocation.Customers.Infra.Stores
{
    public class Store : IStore
    {
        private readonly DataStore dataStore;

        public Store()
        {
            this.dataStore = new DataStore("customers.json");
        }

        public IDocumentCollection<CustomerEntity> Customers =>
            this.dataStore.GetCollection<CustomerEntity>("customers");
    }
}
