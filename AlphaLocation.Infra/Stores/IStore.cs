using AlphaLocation.Customers.Infra.Entities;
using JsonFlatFileDataStore;

namespace AlphaLocation.Customers.Infra.Stores
{
    public interface IStore
    {
        IDocumentCollection<CustomerEntity> Customers { get; }
    }
}