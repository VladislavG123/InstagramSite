using System;
using System.Collections.Generic;

namespace Instagram.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Image { get; set; }
        public string Description { get; set; }

        public virtual User Owner { get; set; }
        public virtual List<Like> Likes { get; set; } = new List<Like>(); 
    }
}