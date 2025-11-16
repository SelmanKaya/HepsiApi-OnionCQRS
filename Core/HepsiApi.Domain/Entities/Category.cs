using HepsiApi.Domain.common;
using HepsiApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Domain.Entities
{
    public class Category : EntityBase
    {

        public Category() { }
        public Category(int parentId, string name, int priorty)
        {
            this.parentId = parentId;
            this.name = name;
            this.priorty = priorty;
        }
        public required int parentId { get; set; }
        public required string name { get; set; }
        public required int priorty { get; set; }

        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}