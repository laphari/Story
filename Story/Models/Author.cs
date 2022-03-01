using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Story.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set;}
        public string AuthorName { get; set;}
        public string AuthorAvatar { get; set;}
        public DateTime AuthorDateOfBirth { get; set;}
        public string AuthorContact { get; set;}
        public string AuthorDescription { get; set;}
        public Story Stories { get; set;}
    }
}