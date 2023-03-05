using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_MVC.DataAccessLayer.DataModels
{
    public class ArticleRow
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime creationDate { get; set; }
        public string Tags { get; set; }
        public string imagePath { get; set; }
    }
}