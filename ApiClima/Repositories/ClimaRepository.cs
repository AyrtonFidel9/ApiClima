using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiClima.Model;
using System.Linq;

namespace ApiClima.Repositories
{
    public class ClimaRepository : iClimaRepository
    {
        private readonly ClimaContext _context;

        public ClimaRepository(ClimaContext context)
        {
            this._context = context;
        }

        public async Task<Clima> Create(Clima clima)
        {
            _context.Climas.Add(clima);
            await _context.SaveChangesAsync();

            return clima;
        }

        public async Task Delete(int id)
        {
            var climaDelete = await _context.Climas.FindAsync(id);
            _context.Climas.Remove(climaDelete);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Clima> Get()
        {
            return _context.Climas.ToList();
        }

        public async Task<Clima> Get(int id)
        {
            return await _context.Climas.FindAsync(id);
        }

        public async Task Update(Clima clima)
        {
            _context.Entry(clima).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<Clima> GetForCiudad(string ciudad)
        {
            return await _context.Climas
                .Where(o => o.Ciudad == ciudad)
                .FirstOrDefaultAsync();
        }

    }
}
