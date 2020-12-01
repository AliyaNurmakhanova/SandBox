using SandBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Interfaces
{
    public interface IDoramasCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
