using SandBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.ViewModels
{
    public class DoramasViewModel
    {
        public IEnumerable<Doramas> AllDoramas { get; set; }
        public string CurrCategory { get; set; }
    }
}
