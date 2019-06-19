using System.Collections.Generic;
using System.Threading.Tasks;
using apiTestUnipCore.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace apiTestUnipCore.Repository
{
    public class MainMenuRepository : IRepository<MainMenu>
    {
        private readonly IContext<MainMenu> _context;

        public MainMenuRepository(IContext<MainMenu> context)
        {
            _context = context;
        }

        public async Task Create(MainMenu item)
        {
            await _context.collection.InsertOneAsync(item);
        }

        public async Task<bool> Delete(string id)
        {
            var result = await _context.collection.FindOneAndDeleteAsync(x => x.Id == id);
            return true;
        }

        public async Task<IEnumerable<MainMenu>> GetAll()
        {
            return await _context.collection.Find(_ => true).ToListAsync();
        }

        public async Task<MainMenu> GetById(string id)
        {
            return await _context.collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(string id, MainMenu item)
        {
            await _context.collection.ReplaceOneAsync(doc => doc.Id == id, item);
        }
    }
}