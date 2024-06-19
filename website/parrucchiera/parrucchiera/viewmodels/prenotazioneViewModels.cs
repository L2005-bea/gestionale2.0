using parrucchiera.Models;

namespace parrucchiera.viewmodels
{
    public class PrenotazioneViewModels
    {
        public prenotazione prenotazione { get; set; }

        public PrenotazioneViewModels(prenotazione prenotazione)
        {
            this.prenotazione = prenotazione;
        }


    }
}

