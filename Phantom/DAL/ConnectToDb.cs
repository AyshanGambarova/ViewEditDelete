using Microsoft.EntityFrameworkCore;
using Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.DAL
{
    public class ConnectToDb:DbContext
    {
        public ConnectToDb(DbContextOptions<ConnectToDb> options) : base(options)
        { }

        public DbSet<Messages> Messages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}
