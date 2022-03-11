using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phantom.DAL;
using Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly ConnectToDb db;
        public MessageController(ConnectToDb _db)
        {
            db = _db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Messages.ToListAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await db.Messages.FirstOrDefaultAsync(x => x.Id == id));
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Messages messages)
        {
            messages.Date = DateTime.Now;
            if (ModelState.IsValid)
            {

            }
            await db.Messages.AddAsync(messages);
            await db.SaveChangesAsync();
            return RedirectToAction("Index","Message");
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View(await db.Messages.FindAsync(id));
        }

        public async Task<IActionResult> Permanentlydelete(int id)
        {
            Messages messageToDelete = await db.Messages.FindAsync(id);
            db.Messages.Remove(messageToDelete);
            await db.SaveChangesAsync();
            return RedirectToAction("index", "Message");

        }
    }
}
