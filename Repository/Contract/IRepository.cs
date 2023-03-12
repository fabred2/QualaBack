using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contract
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Update(T Object);
        Task<T> Insert(T Object);
        Task<IEnumerable<T>> GetAll();
        Task<T> Delete(T Object);
        Task<T> GetById(int Id);

    }
}
