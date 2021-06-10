using Inventory.Interfaces;
using ItemSystem.Interfaces;
using ItemSystem.Interfaces.Modificators;
using ItemSystem.Interfaces.Parameters;
using Parameters.Interfaces;

namespace ItemSystem
{
	public class HPItem : IItem, IHPEntityParameterModificator
	{
		public IEntityParameterStorage Modify(
			IHPEntityParameter baseParameter,
			IHPEntityParameter parameterAccumulator,
			int count
		)
		{
			
		}

		public IEntityParameterStorage BaseEntityParameterProxy { get; set; }
		public IEntityInventoryStorage InventoryProxy { get; set; }
	}
}