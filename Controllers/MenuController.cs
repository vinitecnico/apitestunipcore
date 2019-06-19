using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTestUnipCore.Model;
using apiTestUnipCore.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace apiTestUnipCore.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IRepository<Model.MainMenu> _mainMenuRepository;

        public MenuController(IRepository<Model.MainMenu> mainMenuRepository)
        {
            _mainMenuRepository = mainMenuRepository;
        }

        // GET api/menu
        [HttpGet]
        public async Task<IEnumerable<MainMenu>> Get()
        {
            var result = await _mainMenuRepository.GetAll();
            return result.ToList();
        }

        // GET api/menu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainMenu>> Get(string id)
        {
            var result = await _mainMenuRepository.GetById(id);
            return result;
        }

        // POST api/menu
        [HttpPost]
        public async Task Post([FromBody] MainMenu item)
        {
            await _mainMenuRepository.Create(item);
        }

        // PUT api/menu/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody] MainMenu item)
        {
            await _mainMenuRepository.Update(id, item);
        }

        // DELETE api/menu/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(string id)
        {
            return await _mainMenuRepository.Delete(id);
        }
    }
}
