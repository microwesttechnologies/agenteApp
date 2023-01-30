using System;
using System.ComponentModel.DataAnnotations;

namespace CursoProgramacion.Models
{


    
    public class AgentModel
    {
        public int agente_A { get; set; }

        public int agente_B { get; set; }

        public int agente_C { get; set; }

        public int numero_1 { get; set; }

        public int numero_2 { get; set; }

        public int numero_3 { get; set; }

        public int numero_4 { get; set; }

        public string? Accion { get; set; }

        public int Respuesta { get; set; }

    }
}
