using Crud_Operation_Practice.DataContext;
using Crud_Operation_Practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Operation_Practice.Controllers
{
    public class ProductController : Controller
    {
        private readonly databaseContext _context;

        public ProductController(databaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Practice = _context.Products.ToList();

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product proddata)
        {
            _context.Products.Add(proddata);
            _context.SaveChanges();
            return View();
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var proddel = _context.Products.Find(Id);
            _context.Products.Remove(proddel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
           ViewBag.updateprod = _context.Products.Find(Id);
            return View();
        }
        [HttpPost]
        public IActionResult Update(Product prod)
        {
            _context.Products.Update(prod);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
