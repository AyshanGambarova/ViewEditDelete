using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phantom.DAL;
using Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly ConnectToDb db;
        public BlogController(ConnectToDb _db)
        {
            db = _db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Blogs.ToListAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await db.Blogs.FindAsync(id));
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Blog blog)
        {
            if (ModelState.IsValid)
            {

            }
            await db.Blogs.AddAsync(blog);
            await db.SaveChangesAsync();
            return RedirectToAction("Index","Blog");
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View(await db.Blogs.FindAsync(id));
        }

        public async Task<IActionResult> Permanentlydelete(int id)
        {
            Blog blogtodelete = await db.Blogs.FindAsync(id);
            db.Blogs.Remove(blogtodelete);
            await db.SaveChangesAsync();
            return RedirectToAction("index", "Blog");

        }
    }
}
