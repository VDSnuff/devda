using System;
using devda.model;
using Microsoft.EntityFrameworkCore;

namespace devda
{
    public class DevdaContext : DbContext
    {
        public DevdaContext(DbContextOptions<DevdaContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
