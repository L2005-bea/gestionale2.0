using Parruchiera.Models;
namespace Parruchiera.viewmodels
{
	public class parrucchieraViewModels
	{
		public List<paruchiera> parrucchiera { get; set; }

		public parrucchieraViewModels(List<paruchiera> parrucchiera)
		{
			this.parrucchiera = parrucchiera;
		}
	}
}
