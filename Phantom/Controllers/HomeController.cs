using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phantom.DAL;
using Phantom.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConnectToDb db;
        public HomeController(ConnectToDb _db)
        {
            db = _db;
        }


        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel{
                Banner=db.Banners.FirstOrDefault(),
                Blogs=db.Blogs.ToList()
            };

            return View(hvm);
        }
        public IActionResult addMessage(string name,string email,string message)
        {
            Messages m = new Messages();
            m.Name = name;
            m.Email = email;
            m.Message = message;
            m.Date = DateTime.Now;

            db.Messages.Add(m);
            db.SaveChanges();
            
            return RedirectToAction("Index", "Home");
            
        }

    }
}
