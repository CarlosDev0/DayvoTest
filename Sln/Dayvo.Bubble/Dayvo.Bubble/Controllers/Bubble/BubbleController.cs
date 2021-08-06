using Dayvo.Negocio.BM.Bubble;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dayvo.Bubble.Controllers.Bubble
{
    public class BubbleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IEnumerable<string> OrderBurbuja(Boolean Asc, string Texto) {
            BMBubble bMBubble = new BMBubble();
            string[] txtNumb = Texto.Split(',');
            int[] numbers;
            numbers = new int[txtNumb.Length];
            for (int i = 0; i < txtNumb.Length; i++)
            {
                //Lista de Enteros
                numbers.SetValue(Convert.ToInt32(txtNumb.GetValue(i)), i);
            }
            IEnumerable<string> resultado;
            if (Asc)
            {
                resultado = bMBubble.SortAscending(numbers);
            }
            else {
                resultado = bMBubble.SortDescending(numbers);
            }
            return resultado;
        }
    }
}
