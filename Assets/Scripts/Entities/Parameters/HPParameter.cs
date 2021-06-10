using ItemSystem.Interfaces.Modificators;
using ItemSystem.Interfaces.Parameters;

namespace Entitis.Parameters
{
	public class HPParameter : IHPEntityParameter
	{
		public float Value { get; set; } = 0;
	}
}