﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                 new Product { Id = 1,Name ="Kalem1", CaategoryId=1,Price=100,Stock=20,CreatedDate=DateTime.Now },
                 new Product { Id = 2, Name = "Kalem2", CaategoryId = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now },

                 new Product { Id = 3, Name = "Kalem3", CaategoryId = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now },



                 new Product { Id = 4, Name ="Kitap1",CaategoryId = 2, Price = 200, Stock = 30, CreatedDate = DateTime.Now },
                 new Product { Id = 5,Name="Defter1", CaategoryId = 3, Price = 140, Stock = 13, CreatedDate = DateTime.Now }
             );
        }
    }
}
