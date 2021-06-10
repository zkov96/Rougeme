using Inventory.Interfaces;
using ItemSystem.Interfaces.Parameters;
using Parameters.Interfaces;

namespace ItemSystem.Interfaces.Modificators
{
	public interface IEntityParameterModificator
	{
		// IEntityParameter Modificate(IEntityParameter parameter);

		IEntityParameterStorage BaseEntityParameterProxy { get; set; }
		IEntityInventoryStorage InventoryProxy { get; set; }
	}

	public interface IEntityParameterModificator<T> : IEntityParameterModificator where T : IEntityParameter
	{
		IEntityParameterStorage Modify(T baseParameter, T parameterAccumulator, int count);
	}
}