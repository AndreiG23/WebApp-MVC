using System.Collections.Generic;
using WebApp_MVC.DataAccessLayer.DataModels;
using WebApp_MVC.Models;

namespace WebApp_MVC.DataAccessLayer.Repositories
{
    public class BlogSiteRepository
    {
        public static List<BlogSite> LoadBlogSites()
        {
            string sql = @"SELECT BlogSiteId, Title, Description from dbo.BlogSites;";

            List<BlogSiteRow> rows = SqlDataAccess.LoadData<BlogSiteRow>(sql);
            List<BlogSite> blogSites = new List<BlogSite>();
            foreach (BlogSiteRow row in rows)
            {
                BlogSite blogSite = new BlogSite();
                blogSite.BlogSiteId = row.BlogSiteId;
                blogSite.Title = row.Title;
                blogSite.Description = row.Description;
                blogSites.Add(blogSite);
            }
            return blogSites;
        }
    }
}