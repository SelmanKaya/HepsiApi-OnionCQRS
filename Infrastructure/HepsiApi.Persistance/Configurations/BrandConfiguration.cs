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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.name).HasMaxLength(256);
            Faker faker = new("tr");

            Brand brand1 = new()
            {
                id = 1,
                name = faker.Commerce.Department(),
                createdDate = DateTime.Now,
                isDeleted = false
            };
            Brand brand2 = new()
            {
                id = 2,
                name = faker.Commerce.Department(),
                createdDate = DateTime.Now,
                isDeleted = false
            };
            Brand brand3 = new()
            {
                id = 3,
                name = faker.Commerce.Department(),
                createdDate = DateTime.Now,
                isDeleted = true
            };

            builder.HasData(brand1, brand2, brand3);

        }
    }
}
