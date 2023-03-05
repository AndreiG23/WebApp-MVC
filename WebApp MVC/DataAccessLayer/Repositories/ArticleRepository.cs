using System.Collections.Generic;
using System.Linq;
using WebApp_MVC.DataAccessLayer.DataModels;
using WebApp_MVC.Models;

namespace WebApp_MVC.DataAccessLayer.Repositories
{
    public static class ArticleRepository
    {
        public static List<Article> LoadArticles()
        {
            string sql = @"SELECT ArticleId, Name, Description, Content, Category, CreationDate, Tags, ImagePath from dbo.Articles;";

            List<ArticleRow> rows = SqlDataAccess.LoadData<ArticleRow>(sql);
            List<Article> articles = new List<Article>();
            foreach (ArticleRow row in rows)
            {
                Article article = new Article();
                article.ArticleId = row.ArticleId;
                article.Name = row.Name;
                article.Description = row.Description;
                article.Content = row.Content;
                article.creationDate = row.creationDate;
                article.Category = row.Category;
                article.imagePath = row.imagePath;
                article.Tags = row.Tags.Split(',').ToList<string>();

                articles.Add(article);
            }
            return articles;
        }
    }
}