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
    }
}
