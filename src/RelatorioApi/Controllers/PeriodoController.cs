using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelatorioApi.Dominio.Entities;

namespace RelatorioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodoController : ControllerBase
    {
        private readonly ApiContext _context;

        public PeriodoController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Periodo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Periodo/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Periodo> Get(int id)
        {
            var periodo = await _context.Periodos.FindAsync(id);

            if (periodo == null)
            {
                return null;
            }

            return periodo;
        }

        // POST: api/Periodo
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Periodo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
