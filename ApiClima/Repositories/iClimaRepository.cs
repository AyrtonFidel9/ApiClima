using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiClima.Model;


namespace ApiClima.Repositories
{
    public interface iClimaRepository
    {
        IEnumerable<Clima> Get();
        Task<Clima> Get(int id);
        Task<Clima> Create(Clima clima);
        Task Update(Clima clima);
        Task Delete(int id);

        Task<Clima> GetForCiudad(string ciudad);
    }
}
