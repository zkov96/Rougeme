using System;
using System.Collections.Generic;
using Inventory.Interfaces;
using ItemSystem;
using ItemSystem.Interfaces;

namespace Inventory
{
	public class Inventory : IEntityInventoryStorage
	{
		private Dictionary<Type, IInventoryItem> _items;

		public Dictionary<Type, IInventoryItem> Items => _items;

		public IInventoryItem<T> GetItem<T>() where T : IItem
		{
			return (IInventoryItem<T>) GetItem(typeof(T));
		}

		public IInventoryItem GetItem(Type itemType)
		{
			return _items.ContainsKey(itemType) ? _items[itemType] : null;
		}

		public void ChangeItem<T>(int amount = 1) where T : IItem
		{
			ChangeItem(typeof(T), amount);
		}

		private void ChangeItem(Type itemType, int amount = 1)
		{
			CreatIfNeed(itemType);

			_items[itemType].Count = amount;

			RemoveIfNeed(itemType);
		}

		public bool Remove<T>()
		{
			return Remove(typeof(T));
		}

		private bool Remove(Type itemType)
		{
			if (!_items.ContainsKey(itemType))
			{
				return false;
			}

			_items.Remove(itemType);

			return true;
		}

		private void CreatIfNeed<T>()
		{
			CreatIfNeed(typeof(T));
		}

		private void CreatIfNeed(Type itemType)
		{
			if (!_items.ContainsKey(itemType))
			{
				_items.Add(itemType, new InventoryItem((IItem) Activator.CreateInstance(itemType)));
			}
		}

		private void RemoveIfNeed<T>()
		{
			RemoveIfNeed(typeof(T));
		}

		private void RemoveIfNeed(Type itemType)
		{
			if (_items.ContainsKey(itemType) && _items[itemType].Count <= 0)
			{
				Remove(itemType);
			}
		}
	}
}