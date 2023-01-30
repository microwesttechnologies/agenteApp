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

    public class CalculadoraController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CalculadoraController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Calcular(Calculadora objCalculadora)
        {

            float n1 = objCalculadora.Num1;
            float n2 = objCalculadora.Num2;
            float n3 = objCalculadora.Num3;
            float n4 = objCalculadora.Num4;

            if ("A".Equals(objCalculadora.Accion))
            {
                objCalculadora.Respuesta = (n1 + n2 + n3 + n4) / 4;
                Console.WriteLine("Esta es la media aritmetica: " + objCalculadora.Respuesta + "");
            }
            else if ("B".Equals(objCalculadora.Accion))
            {
                objCalculadora.Respuesta = 4 / ((1 / n1) + (1 / n2) + (1 / n3) + (1 / n4));
                Console.WriteLine("Esta es la media harmonica: " + objCalculadora.Respuesta + "");
            }
            else if ("C".Equals(objCalculadora.Accion))

            {
                float[] valores = { n1, n2, n3, n4 };
                Array.Sort(valores);

                if (valores.Length % 2 == 0)
                {
                    int n = valores.Length;
                    float mediana = (valores[n / 2 - 1] + valores[n / 2]) / 2;
                    objCalculadora.Respuesta = mediana;
                    Console.WriteLine("la mediana es " + mediana);

                }
                else
                {
                    int mediana = valores.Length / 2;
                    objCalculadora.Respuesta = mediana;
                    Console.WriteLine("la mediana es " + mediana);
                }
            }

            return View("index", objCalculadora);

        }

        

    }

}
