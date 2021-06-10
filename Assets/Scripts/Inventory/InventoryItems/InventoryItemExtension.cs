using System;
using ItemSystem.Interfaces;

namespace ItemSystem
{
	public static class InventoryItemExtension
	{
		public static InventoryItem<T> AsTyped<T>(this InventoryItem inventoryItem) where T : IItem
		{
			if (inventoryItem.Item is T item)
			{
				return new InventoryItem<T>(item, inventoryItem.Count);
			}
			else
			{
				throw new Exception("Can`t convert");
			}
		}
	}
}