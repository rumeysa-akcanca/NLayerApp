using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        // implemente ettiğimiz zaman ,DBContext'in  SaveChanges,SAvechangeAsync metotlarını çağırıyor olacağız
        
        Task CommitAsync();
        void Commit();
    }
}
