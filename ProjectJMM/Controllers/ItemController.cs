using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectJMM.DBData;
using ProjectJMM.Models;

namespace ProjectJMM.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext1;
        public ItemController(ApplicationDbContext applicationDbContext)
        {
            applicationDbContext1 = applicationDbContext;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Item> objList = applicationDbContext1.Items;
            return View(objList);
        }
        [HttpGet]
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item)
        {
            applicationDbContext1.Items.Add(item);
            applicationDbContext1.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
