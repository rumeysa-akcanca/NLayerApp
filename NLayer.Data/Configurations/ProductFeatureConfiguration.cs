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
    internal class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            //FEature 'in Product'la birebir ilişkisi var
            //ProductFeature'ın bir tane product'ı olabilir,Product'ın da bir tane productfeature'ı olobilir birebir ilişki
            //Kimde foreignkey var productfeature 'da var , productıd benim için foreignkey
            builder.HasOne(c => c.Product).WithOne(c => c.ProductFeature).HasForeignKey<ProductFeature>(c => c.Product.Id);
        }
    }
}
