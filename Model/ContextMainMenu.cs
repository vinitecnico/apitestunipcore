using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace apiTestUnipCore.Model
{
     public class ContextMainMenu : IContext<MainMenu>
    {
        private readonly IMongoDatabase _db;

        public ContextMainMenu(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<MainMenu> collection => _db.GetCollection<MainMenu>("itemMenu");
    }
}