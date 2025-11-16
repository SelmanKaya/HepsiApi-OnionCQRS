using HepsiApi.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Domain.Entities
{
    public class Brand : EntityBase
    {

        public Brand() { }
        public Brand(string name)
        {
            this.name = name;
        }
        public required string name { get; set; }   
    }
}
