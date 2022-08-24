using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);//id'si key olacak
            builder.Property(c => c.Id).UseIdentityColumn();//Identity birer birer artsın
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);//zorunlu,db'de nullable olmasın,max uzunluk 50 

            builder.ToTable("Categories"); //tablonun ismi default olarak dbset<isim> . Tabloya isim veriyoruz
        }
    }
}
