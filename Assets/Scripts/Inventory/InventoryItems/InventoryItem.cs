using Inventory.Interfaces;
using ItemSystem.Interfaces;

namespace ItemSystem
{
	public class InventoryItem : IInventoryItem
	{
		public IItem Item { get; set; }
		public float Count { get; set; }

		public InventoryItem(IItem item, float count = 0)
		{
			Item = item;
			Count = count;
		}
	}

	public class InventoryItem<T> : InventoryItem, IInventoryItem<T> where T : IItem
	{
		public T Item
		{
			get => (T) base.Item;
			set => base.Item = value;
		}

		public InventoryItem(T item, float count = 0) : base(item, count)
		{
		}
	}
}