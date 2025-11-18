using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Domain.common
{
    public class EntityBase : IEntityBase
    {
        public int id { get; set; }
        public DateTime createdDate { get; set; } = DateTime.Now;
        public bool isDeleted { get; set; } = false;

    }
}
