using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Stock).IsRequired();
            //################.## //toplam 18 karakter , virgülden sonra iki karakter
            builder.Property(c => c.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.ToTable("Products");

            //EF core aradaki ilişkiyi anlıyor, açık açık vermek gerekirse
            //builder aslında product
            //bir products'in bir categorysi olabilir: hasone
            //bir category'nin de birden fazla products'ı olabilir : withmany
            //Foreignkey : CategoryId

            builder.HasOne(c => c.Category).WithMany(c => c.Products).HasForeignKey(c => c.CaategoryId);
        }
    }
}
