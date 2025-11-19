using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HepsiApi.Domain.Entities;
using Bogus;

namespace HepsiApi.Persistance.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");
            Product product1 = new()
            {
                id = 1,
                title = faker.Commerce.ProductName(),
                description = faker.Commerce.ProductDescription(),
                brandId = 1,
                discount = faker.Random.Decimal(0,10),
                price = faker.Finance.Amount(10,1000),
                createdDate = DateTime.Now,
                isDeleted = false
            };
            Product product2 = new()
            {
                id = 2,
                title = faker.Commerce.ProductName(),
                description = faker.Commerce.ProductDescription(),
                brandId = 3,
                discount = faker.Random.Decimal(0, 10),
                price = faker.Finance.Amount(10, 1000),
                createdDate = DateTime.Now,
                isDeleted = false
            };
            builder.HasData(product1, product2);
        }
    }
    
}
