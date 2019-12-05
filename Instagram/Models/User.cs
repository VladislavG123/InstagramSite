using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string Information { get; set; }

        public virtual List<Post> Posts { get; set; } = new List<Post>();
        public virtual List<Like> Likes { get; set; } = new List<Like>();
        public virtual List<Comment> Comments { get; set; } = new List<Comment>();

    }
}
