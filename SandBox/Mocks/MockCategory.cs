using SandBox.Interfaces;
using SandBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Mocks
{
    public class MockCategory : IDoramasCategory
    {
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "2015", Desc = "2015 doramas"},
                    new Category {CategoryName = "2016", Desc = "2016 doramas"},
                    new Category {CategoryName = "2017", Desc = "2017 doramas"},
                    new Category {CategoryName = "2018", Desc = "2018 doramas"},
                    new Category {CategoryName = "2019", Desc = "2019 doramas"},
                    new Category {CategoryName = "2020", Desc = "2020 doramas"},
                };
            }
        }

    }
}
