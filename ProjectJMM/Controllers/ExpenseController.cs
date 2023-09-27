using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            if (ModelState.IsValid)
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);

        }
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }



            [HttpPost]
            [ValidateAntiForgeryToken]

            public IActionResult DeletePost(int? id)
            {
                var obj = _context.Expenses.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }
                _context.Expenses.Remove(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");


            }
        public IActionResult Update(int id)
        {
            var expense = _context.Expenses.Find(id);
            if (expense == null)
            {
                return NotFound();
            }
            return View(expense);
        }

        [HttpPost]
        public IActionResult Update(int id, Expense expense)
        {
            if (id != expense.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }

    }


} 

