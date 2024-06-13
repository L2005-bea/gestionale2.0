
using parrucchiera.Models;

namespace Paruchiera.viewmodels
{
	public class parrucchieriViewModels
	{
		public List<parrucchiera> Parrucchiera { get; set; }

		public parrucchieriViewModels(List<Parrucchiera> Parrucchiera) => this.Parrucchiera = Parrucchiera;
	}

	public class Parrucchiera
	{
	}
}
