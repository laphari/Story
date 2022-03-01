using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Story.Models
{
    public class Story
    {
        [Key]
        public int StoryID { get; set;}
        public string StoryName { get; set;}
        public string StoryDescription { get; set;}
        public string StoryIsDone { get; set;}
        public DateTime StoryCreated { get; set;}
        public DateTime StoryUpdated { get; set;}
        public DateTime StoryDeleted { get; set;}
        public ICollection<Chapter> GetChapters { get; set;}
        public Author Authors { get; set;}
        public Category Categories { get; set;}
    }
}