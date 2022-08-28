using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class ProductFeature 
    {
        public int Id { get; set; }
        public string Colar { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        //Bir prodct' a ait olacak product id tutmalıyız
        public int ProductId { get; set; }//Foreign Key
        public Product Product { get; set; }

    }

}
