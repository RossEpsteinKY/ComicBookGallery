using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            
            

            ViewBag.SeriesTitle = "";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "";
            ViewBag.Artists = new string[]
            {
                ""
            };



            object comicBook = null;
            return View(comicBook);
        }
    }
}