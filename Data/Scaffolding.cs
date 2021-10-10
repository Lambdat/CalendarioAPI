using CalendarioAPI.Models;
using CalendarioAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarioAPI.Data
{
    //Questa classe serve solo per raccogliere i dati

    // Estendiamo ed implementiamo l'interfaccia, sovrascrivendo il generic <T> con Evento
    public class Scaffolding : ICalendarioService<Evento>
    {
        //Lista di Eventi in Scaffolding
        private List<Evento> _eventi = new List<Evento>
        {

            new Evento()
            {
               Inizio=new DateTime(2021,12,25,09,00,00),
               Fine=new DateTime(2021,12,25,10,30,00),
               Titolo="Fare Regali di Natale",
               Descrizione="Andare a fare una tonnellata di regali, " +
                "prima del pranzo natalizio"
            },

            new Evento()
            {
                Inizio= new DateTime(2021,10,30,18,15,00),
                Fine= new DateTime(2021,10,30,18,50,00),
                Titolo="Comprare Zucche Halloween",
                Descrizione="Andare dal fruttivendolo e comprare zucche " +
                "da rintagliare per indossarle alla festa delle streghe"
            },

            new Evento()
            {
                Inizio= new DateTime(2021,11,01,12,15,00),
                Fine= new DateTime(2021,11,01,14,55,00),
                Titolo= "Pranzo da Nonna",
                Descrizione= "Andare a pranzo e uscirne come " +
                "porcellini"
            },

            new Evento()
            {
                Inizio= new DateTime(2021,10,10,18,30,00),
                Fine= new DateTime(2021,10,10,19,30,00),
                Titolo="Finire la Classe del Beone su Elysium",
                Descrizione="Arrivare a completare fino al livello 10 \n" +
                "la classe del Beone"
            }

        };

        public void Aggiungi(Evento t)
        {
            throw new NotImplementedException();
        }

        public Evento Cerca(string titolo)
        {
            throw new NotImplementedException();
        }

        public List<Evento> Elenco()
        {
            return _eventi;
        }

        public List<Evento> ElencoTraIntervallo(DateTime inizio, DateTime fine)
        {
            throw new NotImplementedException();
        }

        public void Elimina(string titolo)
        {
            throw new NotImplementedException();
        }

        public void Modifica(string titolo, Evento t)
        {
            throw new NotImplementedException();
        }
    }
}
