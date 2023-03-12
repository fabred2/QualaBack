using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Contract;
using Entities;

namespace Domain.Contract
{
    public interface ISucursalDomain
    {
        Task<IEnumerable<Sucursales>> GetAll();
        Task<Sucursales> Update(Sucursales Object);
        Task<Sucursales> Insert(Sucursales Object);
        Task<Sucursales> Delete(Sucursales Object);
        Task<Sucursales> GetById(int Id);
    }
}
