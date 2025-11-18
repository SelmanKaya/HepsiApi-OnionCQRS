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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
          Faker faker = new("tr");
          Detail detail1 = new()
          {
              id = 1,
              title = faker.Lorem.Sentence(1),
              description = faker.Lorem.Sentence(5),
              categoryId = 1,
              createdDate = DateTime.Now,
              isDeleted = false
          };
            Detail detail2 = new()
            {
                id = 2,
                title = faker.Lorem.Sentence(2),
                description = faker.Lorem.Sentence(5),
                categoryId = 3,
                createdDate = DateTime.Now,
                isDeleted = true
            };
            Detail detail3 = new()
            {
                id = 3,
                title = faker.Lorem.Sentence(1),
                description = faker.Lorem.Sentence(5),
                categoryId = 4,
                createdDate = DateTime.Now,
                isDeleted = false
            };
            builder.HasData(detail1, detail2, detail3);
        }
    }
}
