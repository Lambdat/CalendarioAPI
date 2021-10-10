using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarioAPI.Models
{
    public class Evento
    {
       
        public DateTime Inizio { get; set; }
        public DateTime Fine { get; set; }

        public string Titolo { get; set; }
        public string Descrizione { get; set; }

    }
}
