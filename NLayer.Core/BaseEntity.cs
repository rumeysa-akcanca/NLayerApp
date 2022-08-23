using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public abstract class BaseEntity
    {
        //abstract : nesne örneği alınmaz.
        public int Id { get; set; } //EF core bunu direkt olarak primary key olarak algılıyo

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
