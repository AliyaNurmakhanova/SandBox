using SandBox.Areas.Identity.Data;
using SandBox.Interfaces;
using SandBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Repository
{
    public class CategoryRepository : IDoramasCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
