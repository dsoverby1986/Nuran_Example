using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nuran_Example.Models;

namespace Nuran_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult TagHelperSelectExample()
        {
            ExampleViewModel model = new ExampleViewModel
            {
                SelectList = new SelectList(GetSelectListItems(), "Value", "Text")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult TagHelperSelectExample(ExampleViewModel model)
        {
            // set breakpoint and inspect model.ThingId
            model.SelectList = new SelectList(GetSelectListItems(), "Value", "Text", model.ThingId);
            return View(model);
        }

        public IActionResult JSSelectExample()
        {
            ExampleViewModel model = new ExampleViewModel
            {
                SelectList = new SelectList(GetSelectListItems(), "Value", "Text")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult JSSelectExample(ExampleViewModel model)
        {
            model.SelectList = new SelectList(GetSelectListItems(), "Value", "Text", model.ThingId);
            return View(model);
        }

        private List<SelectListItem> GetSelectListItems()
        {
            string[] optionsText = { "First Thing", "Second Thing", "Third Thing", "Fourth Thing" };
            List<SelectListItem> items = new List<SelectListItem>();
            for (int i = 0; i < optionsText.Length; i++)
                items.Add(new SelectListItem { Text = optionsText[i], Value = (i + 1).ToString() });
            return items;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
