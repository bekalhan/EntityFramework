using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCore.Controllers
{
    public class AuthorController : Controller
    {
        LibraryContext _context = new LibraryContext();
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var authors = _context.Authors;
            return View(await authors.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                _context.Add(author);
                _context.SaveChanges();
                return RedirectToAction("Index", "Author");
            }
            else
            {
                TempData["error"] = "Please be sure fill all field";
                return RedirectToAction("Create");
            }
        }
    }
}

