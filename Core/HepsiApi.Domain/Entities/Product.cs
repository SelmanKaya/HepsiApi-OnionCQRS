using HepsiApi.Domain.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public required string title { get; set; }
        public required string description { get; set; }


        public required int brandId { get; set; }
        public required decimal price { get; set; }
        public required decimal discount { get; set; }

        public Brand Brand { get; set; }
        public ICollection<Category> Categories { get; set; }

        //public required string imagePath { get; set; }

    }
}
