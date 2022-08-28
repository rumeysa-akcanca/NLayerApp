using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Core.Models;
using NLayer.Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    /// ilk olarak sqlserverda veritabanına karşılık gelecek  class oluşturmak. => AppDbContext
    ///DbContext sınıfı , EF core'da herhangi bir ilişkisel veri tabanında veri tabanına karşılık geliyor
    ///Microsoft.EntityFrameworkCore : Orm aracı uygulama ile veritabanı arasında bir köprü vazifesi görecek 
    ///MySql ,PostgreSql gibi birçok ilişkisel veri tabanında çalışabilir
    ///Sql server ile çalışacağımız için 
    ///Microsoft.EntityFrameworkCore.SqlServer
    ///migration komutlarını Visual Stüdio içerisinde package manager console üzerinden yazabilmem için
    ///Microsoft.EntityFrameworkCore.Tools bunu yüklemezsek migration komutlarını herhangi bir komut satırı üzerinden
    ///dotnet clı ı ile gerçekleştirmemiz gerekiyordu

    ///bir sonraki adım veritabanı yolunu belirlemek  
    ///arkasındanda startup dosyasında, bu db yolunu appsetting.json da okuyacak şekilde yazmak
    ///
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            //bu optionsla beraber veritabanı yolunu startup dosyası üzerinden vericez
        }

       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        //entitylerimizle ilgili ayarlarımızı yapabilmemiz için migration sıraısnda gereken methot
        //model oluşurken çalışacak olan methot

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //her bir class library assembly
            //Git bu assembly içerisinden bütün configuration dosyalarını oku
            //Configuration dosyaları aynı interface implemente ettiği için reflection yaparak bu interface sahip tüm classları okuyor 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//getExecutingAssembly çalışmış olduğum assembly
                                                                                          // modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature() {Id =1,Colar="kırmızı", Height= 100,  ProductId=1 , Width= 200},
                new ProductFeature() { Id = 2, Colar = "mavi", Height = 100, ProductId = 2, Width = 200 },
                new ProductFeature() { Id = 3, Colar = "turuncu", Height = 100, ProductId = 3, Width = 200 }

                );


           base.OnModelCreating(modelBuilder);
        }
    }

   

}