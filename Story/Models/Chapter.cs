using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Story.Models
{
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set;}
        public string ChapterName { get; set;}
        public string ChapterContent { get; set;}
        public DateTime ChapterCreated { get; set;}
        public DateTime ChapterUpdated { get; set;}
        public DateTime ChapterDeleted { get; set;}
        public  Story Stories { get; set;}
        public  Author Authors { get; set;}
        public  Category Categories { get; set;}
    }
}