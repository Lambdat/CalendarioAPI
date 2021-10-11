using CalendarioAPI.Models;
using CalendarioAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CalendarioAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventiController : ControllerBase
    {
        //Creaiamo campo di tipo Interfaccia privato a sola lettura del nostro service
        private readonly ICalendarioService<Evento> _iCalendarioService;

        //Creiamo campo di tipo Interfaccia per il Logger che estende il controller
        private readonly ILogger<EventiController> _iLogger;

        //private readonly ILogger<EventiController> _logger;

        //Metodo Costruttore per inizializzare il campo di tipo interfaccia
        public EventiController(ICalendarioService<Evento> _iCalendarioService,
                                ILogger<EventiController> _iLogger)
        {
            this._iCalendarioService = _iCalendarioService;
            this._iLogger = _iLogger;
        }

        //Metodi GET del protocollo HTTP 
        [HttpGet]
        public List<Evento> Elenco()
        {
            _iLogger.LogInformation("Elenco attraverso metodo HTTP GET ");

            return _iCalendarioService.Elenco();
        }

        [HttpGet("{titolo}")] //{titolo} è la wildcard che passerà nel FromRoute
        public Evento Cerca([FromRoute] string titolo)
        {
            _iLogger.LogInformation("Cerca attraverso metodo HTTP GET ");

            return _iCalendarioService.Cerca(titolo);
        }

        //Metodi POST del protocollo HTTP

        [HttpPost]
        public IActionResult Aggiungi([FromBody] Evento t)
        {
            _iLogger.LogInformation("Aggiunto Evento attraverso metodo HTTP POST");

            _iCalendarioService.Aggiungi(t);

            return Ok();
        }

        //Metodi DELETE del protocollo HTTP

        [HttpDelete("{titolo}")]  
        public IActionResult Elimina([FromRoute]string titolo) //fromquery => .../eventi?titolo=natale
        {
            _iLogger.LogInformation("Aggiunto Evento attraverso metodo HTTP DELETE");

            _iCalendarioService.Elimina(titolo.ToLower());

            return Ok();
        }
        
        //Metodi PUT del protocollo HTTP

        [HttpPut]
        public IActionResult Modifica([FromBody] Evento t)
        {
            _iLogger.LogInformation("Aggiunto Evento attraverso metodo HTTP PUT");

            _iCalendarioService.Modifica(t);

            return Ok();
        }


    }
}
