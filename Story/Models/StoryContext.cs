using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Story.Models
{
    public class StoryContext :DbContext
    {

        public StoryContext() : base("name=Story") { }
        public virtual DbSet<Story> Stories { get; set;}
        public virtual DbSet<Category> Categories { get; set;}
        public virtual DbSet<Author> Authors { get; set;}
        public virtual DbSet<Chapter> Chapters { get; set;}

    }
}