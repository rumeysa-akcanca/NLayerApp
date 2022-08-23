using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        //ASenkron methot
        Task<T> GetByIdAsync(int id);

        //db^ye yapılacak olan sorguyu oluştuturuyoruz
        IQueryable<T> Where(Expression<Func<T,bool>> expression);//yazmış olduğumuz sorgular direk db'ye gitmez, tolist tolistasync gibi metotları çağırınca o zaman db' ye gider
        //amaç veriryi döndükten sonra başka sorgular yazabiliriz, daha performanslı bir şekilde çalışabilmek

        //productRepository.where(x=x.id>5).OrderBy.ToListAsync()
        //list yapsaydık db'den  datayı çeker , datayı çektikten sonra memorye alır , ondan  sonra orderby  yapar
        //direk Iqueryable yaparsak veritabanından orderby 'a göre veri alır.
        //Funcition delege, expression
        //delege : metotoları ifade eden yapılar

        Task<bool> AnyAsync(Expression<Func<T,bool>> expression); //sorgu yazdığımızda

        Task AddAsync (T entity); //uzun süren işlem 


        void Update (T entity); //EF core tarafında bunların asenkron metotları yok.Gerek yok. Ef core memorye alıp takip ettiği bir product'ı classın 

        //sadece state'nı değiştiriyor : uzun süren bir işlem olmadığı iiçin asenkron yapısı yok stake  2ini modify olarak değiştiriyo

            
    }
}
