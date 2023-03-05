using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC.DataAccessLayer.DataModels;
using WebApp_MVC.DataAccessLayer.Repositories;
using WebApp_MVC.Models;

namespace MyFirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        List<BlogSite> sites = BlogSiteRepository.LoadBlogSites();
        List<Article> articles = ArticleRepository.LoadArticles();
        public ActionResult Index()
        {
            ViewBag.Title = sites.FirstOrDefault().Title;
            ViewBag.SubTitle = sites.FirstOrDefault().Description;
            return View(articles);
        }

        public ActionResult ReadOn(int id)
        {
            Article article = articles.FirstOrDefault(a=>a.ArticleId == id);
            ViewBag.Title = sites.FirstOrDefault().Title;
            ViewBag.SubTitle = sites.FirstOrDefault().Description;
            if (article != null)
            {
                return View(article);
            }
            return View();
        }
    }
}