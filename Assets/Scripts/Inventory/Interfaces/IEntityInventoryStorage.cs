using System;
using ItemSystem.Interfaces;

namespace Inventory.Interfaces
{
	public interface IEntityInventoryStorage
	{
		public IInventoryItem<T> GetItem<T>() where T : IItem;
		public IInventoryItem GetItem(Type itemType);
	}
}