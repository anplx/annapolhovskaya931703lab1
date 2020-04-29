using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab1.Models;
using lab1.Services;

namespace lab1.Controllers
{
    public class MyController : Controller
    {
        private readonly IDataSender _myData;
        private MyModel myModel = new MyModel();
        public IActionResult ViewModel()
        {
            return View(myModel);
        }
        public IActionResult ViewDataRes()
        {
            ViewData["MyModel"] = myModel;
           
            return View();
        }
        public IActionResult ViewBagRes()
        {
            ViewBag.MyModel = myModel;
            
            return View();
        }
        public IActionResult ViewService()
        {
            return View(_myData);
        }
    }
}
