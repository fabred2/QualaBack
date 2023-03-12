using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Contract;
using Entities;
using Repository.Contract;

namespace Domain
{
    public class MonedaDomain : IMonedaDomain
    {
        IRepository<Monedas> oIRepository;
        Monedas oSucursal;
        public MonedaDomain(IRepository<Monedas> _oIRepository)
        {
            oIRepository = _oIRepository;
        }
        
        public async Task<IEnumerable<Monedas>> GetAll()
        {
            return await oIRepository.GetAll();
        }
       
    }
}
