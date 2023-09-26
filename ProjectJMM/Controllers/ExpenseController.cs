using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjectJMM.DBData;
using ProjectJMM.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectJMM.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpenseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Expense> expenses = _context.Expenses;
            return View(expenses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
            
        }
    }


}
