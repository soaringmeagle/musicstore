using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();
        public ActionResult Search(string q)
        {
            var albums = db.Albums.Include("Artist").Where(a => a.Title.Contains(q)).Take(10);
            return View(albums);
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}