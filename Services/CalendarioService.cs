using CalendarioAPI.Data;
using CalendarioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarioAPI.Services
{
    public class CalendarioService : ICalendarioService<Evento>
    {
        //Il servizio ha bisogno di leggere i dati lato /Data/Scaffolding
        private readonly Scaffolding _dati;

        //Costruttore, l' Istanza Singleton la prenderemo dalla Dependency Injection
        //in Startup.cs
        public CalendarioService(Scaffolding _dati)
        {
            this._dati = _dati;
        }

        public void Aggiungi(Evento t)
        {
            _dati.Elenco().Add(t);
        }

        public Evento Cerca(string titolo)
        {

             return _dati.Elenco().Where(evento => evento.Titolo.ToLower().Contains(titolo.ToLower())).FirstOrDefault();
            //Metodo Alternativo

            //int indice = _dati.Elenco().FindIndex(evento => evento.Titolo.ToLower().Contains(titolo.ToLower()));

                //return _dati.Elenco()[indice];
        
        }

        public List<Evento> Elenco()
        {
            return _dati.Elenco();
        }

        public List<Evento> ElencoTraIntervallo(DateTime inizio, DateTime fine)
        {
            throw new NotImplementedException();
        }

        public void Elimina(string titolo)
        {
            int indice = _dati.Elenco().IndexOf(Cerca(titolo.ToLower()));
            Console.WriteLine("Indice Elemento da Eliminare: " + indice);

            if(indice>=0)
                _dati.Elenco().RemoveAt(indice);

            /*
             * if(!string)
             * 
             * 
             * */
        }

        public void Modifica(Evento t)
        {

            if (!string.IsNullOrEmpty(t.Titolo))
            {
                int indice = _dati.Elenco().FindIndex(evento => evento.Titolo.ToLower().Contains(t.Titolo.ToLower()));
                Console.WriteLine("Indice da Modificare= " + indice);
                if(indice>=0)
                    _dati.Elenco()[indice] = t;
            }
                
        }
    }
}
