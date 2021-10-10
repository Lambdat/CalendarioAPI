using CalendarioAPI.Models;
using CalendarioAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CalendarioAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventiController : ControllerBase
    {
        //Creaiamo campo di tipo Interfaccia privato a sola lettura
        private readonly ICalendarioService<Evento> _iCalendarioService;

        //Metodo Costruttore per inizializzare il campo di tipo interfaccia
        public EventiController(ICalendarioService<Evento> _iCalendarioService)
        {
            this._iCalendarioService = _iCalendarioService;
        }

        //Metodi GET del protocollo HTTP 
        [HttpGet]
        public List<Evento> Elenco()
        {
            return _iCalendarioService.Elenco();
        }

        [HttpGet("{titolo}")] //{titolo} è la wildcard che passerà nel FromRoute
        public Evento Cerca([FromRoute] string titolo)
        {
            return _iCalendarioService.Cerca(titolo);
        }

        //Metodi POST del protocollo HTTP

        [HttpPost]
        public IActionResult Aggiungi([FromBody] Evento t)
        {
            _iCalendarioService.Aggiungi(t);

            return Ok();
        }



    }
}
