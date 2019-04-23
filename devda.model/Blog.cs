using System.Collections.Generic;

namespace devda.model
{
    public class Blog
    {
        public int BlogId { get; private set; }
        public string Url { get; set; }
        public User User { get; set; }
        public List<Post> Posts { get; set; }
    }
}