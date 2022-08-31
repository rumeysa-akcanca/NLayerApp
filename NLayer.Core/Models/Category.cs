using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        //Aralarındaki ilişkiyi kuralım
        //birden fazla product'ı olabilir
        public ICollection<Product> Products { get; set; }
        //Navigation property : birden fazla  farklı classlara farklı entitylere referans verdiğimiz propertyler
        //Category'den productlara gidebilirim
       
 
    }
}
