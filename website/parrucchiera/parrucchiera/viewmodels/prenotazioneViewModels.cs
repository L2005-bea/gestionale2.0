using parrucchiera.Models;
using System.Collections.Generic;

namespace parrucchiera.viewmodels
{
    public class PrenotazioneViewModels
    {
        public List<prenotazione> prenotazione { get; set; }

        public PrenotazioneViewModels(List<prenotazione> prenotazione)
        {
            this.Prenotazione = prenotazione;
        }


    }
}

