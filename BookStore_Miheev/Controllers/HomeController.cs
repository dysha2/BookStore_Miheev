using BookStore_Miheev.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore_Miheev.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;
            ViewBag.Books = books;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date=DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Thanks " + purchase.Person + " foy you money";
        }
        //[HttpGet]
        //public ActionResult EditBook(int? id)
        //{
        //    if (id == null){
        //        return HttpNotFound();
        //    }

        //}

        //private ActionResult HttpNotFound()
        //{
        //    throw new NotImplementedException();
        //}
    }
}