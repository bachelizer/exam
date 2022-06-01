using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using crud_app_backend.Contracts;
using crud_app_backend.Model;

namespace scholarship_backend.Controllers
{
    [Route("instructor")]
    [ApiController]
    public class CRUDController:ControllerBase
    {
        private readonly ICRUD _crudrepo;
        public CRUDController(ICRUD crudrepo)
        {
            _crudrepo = crudrepo;
        }
        [HttpGet]
        public async Task<IEnumerable<Instructor>> ReadAsync()
        {
            return await _crudrepo.Read();
        }
        [HttpPost]
        public async Task CreateAsync(Instructor data)
        {
            await _crudrepo.Create(data);
        }
        [HttpPut]
        public async Task UpdateAsync(Instructor data)
        {
            await _crudrepo.Update(data);
        }
        [HttpDelete]
        public async Task DeleteAsync(int instuctor_id)
        {
            await _crudrepo.Delete(instuctor_id);
        }

    }
}