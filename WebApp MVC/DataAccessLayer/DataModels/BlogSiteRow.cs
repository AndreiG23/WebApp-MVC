using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_MVC.DataAccessLayer.DataModels
{
    public class BlogSiteRow
    {
        public int BlogSiteId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}