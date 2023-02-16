
using IndustrialMachinePark.App.Models;

namespace IndustrialMachinePark.App.Pages
{
	public partial class MachineOverview
	{
		public List<Machine> Machines { get; set; } = default;

		protected override void OnInitialized()
		{
			Machines = MockDataService.Machines;
		}
	}
}
