using parrucchiera.Models;

namespace parrucchiera.viewmodels
{
	public class PrenotazioneViewModels
	{
		private List<parrucchieri> lista_di_cliente2;
		public List<clientes> lista_di_clientes;

		public prenotazione prenotazione { get; set; }
		public clientes clientes { get; set; }
		public PrenotazioneViewModels(prenotazione prenotazione, clientes clientes)
		{
			this.prenotazione = prenotazione;
			this.clientes = clientes;
		}

		public PrenotazioneViewModels(List<clientes> lista_di_clientes)
		{
			this.lista_di_clientes = lista_di_clientes;
		}

		
	}

}

