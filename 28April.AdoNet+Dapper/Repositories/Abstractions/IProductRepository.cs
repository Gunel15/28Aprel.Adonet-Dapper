using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28April.AdoNet_Dapper.Repositories.Abstractions
{
    interface IProductRepository<T>
    {
        void Add(T entity);
        void Update(int id,T entity);
        void Delete(int id);
        List<T> GetAll();   
        T GetById(int id);

    }
}
