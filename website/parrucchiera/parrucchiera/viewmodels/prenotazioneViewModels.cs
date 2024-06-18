using parrucchiera.Models;
using System.Collections.Generic;

namespace parrucchiera.ViewModels
{
    public class PrenotazioneViewModel
    {
        public List<Prenotazione> Prenotazioni { get; set; }

        public PrenotazioneViewModel(List<Prenotazione> prenotazioni)
        {
            this.Prenotazioni = prenotazioni;
        }
    }

    public class Prenotazione
    {
    }
}