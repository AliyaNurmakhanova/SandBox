using Microsoft.EntityFrameworkCore;
using SandBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Areas.Identity.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Doramas> Doramas { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
