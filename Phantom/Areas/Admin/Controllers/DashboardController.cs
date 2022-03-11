using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phantom.Areas.Admin.Models;
using Phantom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly ConnectToDb db;
        public DashboardController(ConnectToDb _db)
        {
            db = _db;
        }
        public async Task< IActionResult> Index()
        {
            DashboardViewModel dvm = new DashboardViewModel();
            dvm.BlogsCount = await db.Blogs.CountAsync();
            return View(dvm);
        }
    }
}
