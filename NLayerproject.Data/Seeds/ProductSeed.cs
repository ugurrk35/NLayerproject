using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerproject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerproject.Data.Seeds
{
    public class ProductSeed:IEntityTypeConfiguration<Product>
    {
        private readonly int[] _Ids;
        public ProductSeed(int[] Ids)
        {
            _Ids=Ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { 
                    Id = 1 ,
                    Name ="Pilot Kalem",
                    Price =12.50m,
                    Stock =100,
                    CategoryId=_Ids[0]
                },
                 new Product
                 {
                     Id = 2,
                     Name = "Kurşun Kalem",
                     Price = 20.50m,
                     Stock = 220,
                     CategoryId = _Ids[0]
                 },
                       new Product
                       {
                           Id = 3,
                           Name = "Tükenmez Kalem",
                           Price = 30.50m,
                           Stock = 320,
                           CategoryId = _Ids[0]
                       },
                         new Product
                         {
                             Id = 4,
                             Name = "Küçük boy defter",
                             Price = 10.30m,
                             Stock = 2220,
                             CategoryId = _Ids[1]
                         },
                              new Product
                              {
                                  Id = 5,
                                  Name = "orta boy defter",
                                  Price = 10.30m,
                                  Stock = 2220,
                                  CategoryId = _Ids[1]
                              },
                               new Product
                               {
                                   Id = 6,
                                   Name = "büyük boy defter",
                                   Price = 10.30m,
                                   Stock = 2220,
                                   CategoryId = _Ids[1]
                               }



                );
                
        }
    }
}
