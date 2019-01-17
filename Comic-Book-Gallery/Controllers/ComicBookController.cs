using ComicBookGallery.Data;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {

        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public IActionResult Index()
        {
        
            return View();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);


            return View(comicBook);
        }
    }
}