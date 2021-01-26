using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodyTranMVC.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
        
    }
}
