using JsonFlatFileDataStore;

namespace AlphaLocation.Customers.Infra
{
    public class Store : IStore
    {
        private readonly DataStore dataStore;

        public Store()
        {
            this.dataStore = new DataStore("customers.json");
        }

        public IDocumentCollection<CustomerInfra> Customers =>
            this.dataStore.GetCollection<CustomerInfra>("customers");
    }
}
