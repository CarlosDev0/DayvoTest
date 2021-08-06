using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dayvo.Bubble.Controllers.Columnas
{
    public class ColumnasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
