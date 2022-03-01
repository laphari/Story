using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Story.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set;}
        public string CategoryName { get; set;}
        public string CategoryDesctiption { get; set;}
        public  Story Stories { get; set;}
    }
}