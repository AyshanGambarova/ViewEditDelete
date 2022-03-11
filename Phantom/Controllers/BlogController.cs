using Microsoft.AspNetCore.Mvc;
using Phantom.DAL;
using Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.Controllers
{
    public class BlogController : Controller
    {
        private readonly ConnectToDb db;
        public BlogController(ConnectToDb _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult addPost(string name,string title,string image,string text)
        {
            Blog blog = new Blog(name,title,image,text);
            //blog.Name = name;
            //blog.Title = title;
            //blog.Img = image;
            //blog.Text = text;
           

            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        public IActionResult Info(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Blog blog = db.Blogs.FirstOrDefault(x => x.Id==id);
            if (blog==null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(blog);
        }
    }
}
