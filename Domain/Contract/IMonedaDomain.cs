using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Domain.Contract
{
    public interface IMonedaDomain
    {
        Task<IEnumerable<Monedas>> GetAll();
        Task<Monedas> Update(Monedas Object);
        Task<Monedas> Insert(Monedas Object);
        Task<Monedas> Delete(Monedas Object);
        Task<Monedas> GetById(int Id);
    }
}
