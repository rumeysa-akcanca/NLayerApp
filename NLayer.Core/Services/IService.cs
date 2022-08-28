using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
   public interface IService <T> where T : class
    {
        //IGenericten farkı ikisinin de dönüş tipleri farklı olacak 
        //şu anda generic kod doublcate değil
        Task<T> GetByIdAsync(int id);

       // IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
       Task<IEnumerable<T>> GetAllAsync();
       
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression); 

        Task <T> AddAsync(T entity);

        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);

        Task UpdateAsync(T Entity);

        Task RemoveAsync(T entity); 

        //sadece state'nı değiştiriyor : 

        Task RemoveRangeAsync(IEnumerable<T> entities);

       
        //db'ye bu değişiklikleri yansıtacağımız için savechangesasync metodu kullanacağız  bu yüzden bunların dönüş tipi asenkron 

    }
}
