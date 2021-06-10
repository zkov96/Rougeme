using ItemSystem.Interfaces;

namespace Inventory.Interfaces
{
	public interface IInventoryItem
	{
		IItem Item { get; set; }
		float Count { get; set; }
	}

	public interface IInventoryItem<T> : IInventoryItem
	{
		T Item { get; set; }
	}
}