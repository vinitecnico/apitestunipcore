using MongoDB.Driver;

namespace apiTestUnipCore.Model
{
    public interface IContext<T> where T : new()
    {
        IMongoCollection<T> collection { get; }
    }
}