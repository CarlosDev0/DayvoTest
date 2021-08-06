using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dayvo.Bubble.Controllers
{
    public class ReplicatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
