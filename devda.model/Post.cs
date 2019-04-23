using System;
using System.Collections.Generic;

namespace devda.model
{
    public class Post
    {
        public int PostId { get; private set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public User User { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
