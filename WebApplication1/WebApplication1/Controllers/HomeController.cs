using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;
using WebApplication1.Logic.CreateTree;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Node> list = new List<Node>() {
                new Node {id=1,name="a",parentid=null },
                new Node {id=2,name="b",parentid=null},
                new Node {id=3,name="c",parentid=1 },
                new Node {id=4,name="d",parentid=null },
                new Node {id=5,name="e",parentid=3 },
                new Node {id=6,name="f",parentid=2 },
                new Node {id=7,name="g",parentid=null }
            };

            List<NewNode> rlt = TreeFns.CreateNewTree(list);

            ViewBag.Cat66 = rlt;

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
