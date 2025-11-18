using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HepsiApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            Category category1 = new()
            {
                id = 1,
                parentId = 0,
                name = "Elektronik",
                priorty = 1,
                createdDate = DateTime.Now,
                isDeleted = false
            };
            Category category2 = new()
            {
                id = 2,
                parentId = 0,
                name = "Moda",
                priorty = 2,
                createdDate = DateTime.Now,
                isDeleted = false
            };
            Category parent1 = new()
            {
                id = 3,
                parentId = 1,
                name = "Bilgisayar",
                priorty = 1,
                createdDate = DateTime.Now,
                isDeleted = false
            };
            Category parent2 = new()
            {
                id = 4,
                parentId = 2,
                name = "Kadin",
                priorty = 1,
                createdDate = DateTime.Now,
                isDeleted = false
            };
            builder.HasData(category1, category2, parent1, parent2);



        }
    }
}
