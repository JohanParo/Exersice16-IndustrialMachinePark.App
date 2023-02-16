namespace IndustrialMachinePark.App.Models
{
	public class MockDataService
	{
		private static List<Machine>? _machines = default!;

		public static List<Machine>? Machines
		{
			get
			{
				//we will use these in initialization of Employees

				_machines ??= InitializeMockMachines();

				return _machines;
			}
		}

		private static List<Machine> InitializeMockMachines()
		{
			var e1 = new Machine
			{
				ID = 1,
				MachineName = "Test",
				Owner = "David"
				
			};

			var e2 = new Machine
			{
				ID = 1,
				MachineName = "Trucker",
				Owner = "David"

			};

			return new List<Machine>() { e1, e2 };
		}
	}

}
