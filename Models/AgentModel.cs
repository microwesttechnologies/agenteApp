using System;
using System.ComponentModel.DataAnnotations;


namespace agenteApp.Models
{
    public class Calculadora
    {
        public float Num1 { get; set; }

        public float Num2 { get; set; }

        public float Num3 { get; set; }

        public float Num4 { get; set; }

        public int H { get; set; }

        public float A { get; set; }


        public string? Accion { get; set; }

        [Display(Name = "La respuesta es : ")]
        public float Respuesta { get; set; }


        [Display(Name = "Validar en la consola")]
        public string? Grafica { get; set; }




    }

}