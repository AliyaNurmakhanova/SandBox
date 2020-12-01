using Microsoft.AspNetCore.Mvc;
using SandBox.Interfaces;
using SandBox.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Controllers
{
    public class DoramasController : Controller
    {
        private readonly IAllDoramas _allDoramas;
        private readonly IDoramasCategory _allCategories;

        public DoramasController(IAllDoramas iAllDoramas, IDoramasCategory iDoramasCat)
        {
            _allDoramas = iAllDoramas;
            _allCategories = iDoramasCat;
        }
        public ViewResult List()
        {
            ViewData["Title"] = "Doramas";
            DoramasViewModel Obj = new DoramasViewModel();
            Obj.AllDoramas = _allDoramas.Doramas;
            Obj.CurrCategory = " ";
            return View(Obj);
        }
    }
}
