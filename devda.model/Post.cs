using System;
using System.Collections.Generic;

namespace devda.model
{
    public class Post
    {
        public int PostId { get; private set; }
        public string Title { get; set; }
        public string Content { get; set; }

        private DateTime creationDay;
        public DateTime CreationDay
        {
            get => creationDay;
            set => creationDay = value;
        }

        public DateTime lastUpdate;
        public DateTime LastUpdate
        {
            get => lastUpdate;
            set => lastUpdate = value;
        }

        public int BlogId { get; set; }
        public User User { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
