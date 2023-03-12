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
    public class SucursalDomain : ISucursalDomain
    {
        IRepository<Sucursales> oIRepository;
        public SucursalDomain(IRepository<Sucursales> _oIRepository) {
            oIRepository = _oIRepository;
        }
        public async Task<Sucursales> Delete(Sucursales Object)
        {
            return await oIRepository.Delete(Object);
        }

        public async Task<IEnumerable<Sucursales>> GetAll()
        {
            return await oIRepository.GetAll();
        }

        public async Task<Sucursales> Insert(Sucursales Object)
        {
            return await oIRepository.Insert(Object);
        }

        public async Task<Sucursales> Update(Sucursales Object)
        {
            return await oIRepository.Update(Object);
        }
        public async Task<Sucursales> GetById(int Id)
        {
            return await oIRepository.GetById(Id);
        }
    }
}
