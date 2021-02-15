using JsonFlatFileDataStore;

namespace AlphaLocation.Customers.Infra
{
    public interface IStore
    {
        IDocumentCollection<CustomerInfra> Customers { get; }
    }
}