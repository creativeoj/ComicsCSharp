using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ComicsCSharp.Models;

namespace ComicsCSharp.Controllers
{
    public class ComicsController : Controller
    {

        //private static List<Comic> comics = new List<Comic>();
        //make ComicsData.cs file and then past "private static List<Comic> comics = new List<Comic>();"
        public IActionResult Index()
        {
            // ViewBag.comics = comics;
            ViewBag.comics = ComicsData.GetAll();
            //something reall example
            return View();
        }

        [HttpPost]
        //public IActionResult Add(string title, int issueNumber)
        //Action handler more property 
        public IActionResult Add(Comic comic)
        {
            // var comic = new Comic(title, issueNumber);
            //comics.Add(comic); after making ComicData block this
            ComicsData.Add(comic);//Action handler 
            return Redirect("/Comics");
            //redirecct is easy to handle route more than View() -oj
            //ViewBag.comics = comics;
            //retrun View();
        }

        [HttpPost]
        public IActionResult Remove(int[] removedComics)
        {
            foreach(int comicId in removedComics)
            {
                ComicsData.RemoveById(comicId);
            }
            return Redirect("Comics");
        }
    }
}
