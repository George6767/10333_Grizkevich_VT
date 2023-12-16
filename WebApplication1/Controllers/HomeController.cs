using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class Home : Controller
    {

        public IActionResult Index()
        {
            ViewData["Text"] = "Лабораторная работа 2";
            return View();
        }

        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }
        }
        private List<ListDemo> _listDemo;



        public Home(List<ListDemo> listDemo)
        {
            _listDemo = listDemo;

        }
    }
}
