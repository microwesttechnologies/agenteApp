using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using agenteApp.Models;

namespace agenteApp.Controllers
{

    public class GraficoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public GraficoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]


        public IActionResult Graficar(Calculadora objGraficar)
        {

            float H = objGraficar.H;
            float A = objGraficar.A;

            if ("A".Equals(objGraficar.Accion))
            {
                for (int nEsc = 0; nEsc <= H; nEsc++)
                {
                    for (int i = 1; i <= nEsc; i++)
                    {
                        Console.Write("*");
                        objGraficar.Grafica = "*";
                    }
                    Console.WriteLine("+");
                }
            }
            else if ("B".Equals(objGraficar.Accion))
            {
                for (int nEsc = 0; nEsc <= H; nEsc++)
                {
                    for (int i = 1; i <= nEsc; i++)
                    {
                        Console.Write("*");
                        objGraficar.Grafica = "*";
                    }
                    Console.WriteLine("+");
                }
            }
            else if ("C".Equals(objGraficar.Accion))

            {

                int x, y, base1;

                base1 = objGraficar.H;

                Console.WriteLine(" ");

                for (x = 0; x < base1 - 1; x++)
                {
                    Console.WriteLine(" ");
                }
                for (x = 0; x < base1; x++)
                {
                    Console.WriteLine("*");
                }

                for (y = 1; y < base1 - 1; y++)
                {
                    Console.WriteLine(" ");
                    for (x = 0; x < base1 - y - 1; x++)
                    {
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("*");
                    for (x = 0; x < base1 + 2 * y - 2; x++)
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine("*");
                }

                for (y = base1; y > 1; y--)
                {
                    Console.WriteLine(" ");
                    for (x = 0; x < base1 - y; x++)
                    {
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("*");
                    for (x = 0; x < base1 + 2 * y - 4; x++)
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine("*");
                }

                Console.WriteLine(" ");
                for (x = 0; x < base1 - 1; x++)
                {
                    Console.WriteLine(" ");
                }
                for (x = 0; x < base1; x++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine(" ");

            }

            return View("index", objGraficar);

        }

    }

}
