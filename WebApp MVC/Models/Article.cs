using System;
using System.Collections.Generic;

namespace WebApp_MVC.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime creationDate { get; set; }
        public List<string> Tags { get; set; }
        public string imagePath { get; set; }
    }
}