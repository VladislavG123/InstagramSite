using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Like
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}
