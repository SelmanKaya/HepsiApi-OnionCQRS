using HepsiApi.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Domain.Entities
{
    public class Detail : EntityBase
    {
        public Detail() { }
        public Detail(string title, string description, int categoryId)
        {
            this.title = title;
            this.description = description;
            this.categoryId = categoryId;
        }
        public required string title { get; set; }
        public required string description { get; set; }

        public required int categoryId { get; set; }

        public Category Category { get; set; }
    }
}
