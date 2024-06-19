using parrucchiera.Models;

namespace parrucchiera.viewmodels
{
	public class clienteViewModels
	{  
        public cliente cliente { get; set; }

		public clienteViewModels(cliente cliente)
		{
			this.cliente = cliente;
		}


	}
}


	