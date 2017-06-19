using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {

        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        //获取浏览页面 GET:/Store/Browse?genre=?Disco
        public string Browse(String genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse,Genre = "+genre);
            return message;           
        }

        //获取详细页面 GET:/Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Detials, ID="+id;
            return message;
        }
	}
}