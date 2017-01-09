using System.Web.Mvc;
using Vidly.Models;
using static System.String;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
           var movie = new Movie() { Name = "Shrek"};

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (IsNullOrWhiteSpace(sortBy))
            {
                sortBy = Empty;
            }
            return Content(Format("pageIndex={0}&{1}"), pageIndex.ToString(), sortBy);
            //return Content(String.Format("pageIndex={0}&sortBy{1}"), pageIndex.ToString(), sortBy);
        }

        public ActionResult Cat()
        {
            var movie = new Movie() { Name = "Shrek" };

            return View(movie);
            //return Content("hello world");
        }
    }
}