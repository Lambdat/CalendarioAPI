using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarioAPI.Services
{
    // Questa è l'interfaccia(contratto da stipulare con le classi) che restituisce dei generics <T>
    public interface ICalendarioService<T>
    {

        public List<T> Elenco();

        public void Aggiungi(T t);

        public T Cerca(string titolo);

        public void Modifica(T t);

        public void Elimina(string titolo);

        public List<T> ElencoTraIntervallo(DateTime inizio,DateTime fine);


    }
}
