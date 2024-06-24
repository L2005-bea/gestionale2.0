using parrucchiera.Models;

namespace parrucchiera.viewmodels
{
    public class prenotazioniViewModels
    {
        public List<prenotazione> lista_prenotazioni;

        public prenotazioniViewModels(List<prenotazione> lista_prenotazioni)
        {
            this.lista_prenotazioni = lista_prenotazioni;


        }
    }
}
