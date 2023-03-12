using Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDBContext context;
        private readonly DbSet<T> entities;
        
        public Repository(ApplicationDBContext context) {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
           return await entities.ToListAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await entities.Where(a => a.Id == Id).FirstAsync();
        }



        public async Task<T> Insert(T Object)
        {
            entities.Add(Object);
            await this.context.SaveChangesAsync();
            return Object;
        }

        public async Task<T> Update(T Object)
        {
            this.context.Entry(Object).State = EntityState.Modified;
            await this.context.SaveChangesAsync();
            return Object;
        }


        public async Task<T> Delete(T Object)
        {
            this.context.Remove(Object);
            await this.context.SaveChangesAsync();
            return Object;
        }
    }
}
