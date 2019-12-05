using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Content { get; set; }
        
        public virtual User Owner { get; set; }
        public virtual Post Post { get; set; }
    }
}
