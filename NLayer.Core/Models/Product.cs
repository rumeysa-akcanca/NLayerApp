using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CaategoryId { get; set; } //Foreign Key (otomatik olarak algılıyo)
        //bir e çok bir ilişki olacak kategory ıd yi tutmalıyız

        //product'ın da bir tane categorysi vardır
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; } 


         public  string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

      
    }
}
