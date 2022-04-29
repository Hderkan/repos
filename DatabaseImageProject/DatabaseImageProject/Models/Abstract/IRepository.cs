using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Abstract
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);

        List<T> GetAll();

        void Delete(T entity);

        void Update(T entity);

        T Get(T entity);

        
    }
}
