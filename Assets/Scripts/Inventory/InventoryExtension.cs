using System;
using System.Collections.Generic;
using System.Linq;
using ItemSystem.Interfaces.Parameters;
using Parameters.Interfaces;

namespace ItemSystem
{
	public static class InventoryExtension
	{
		public static List<Inventory.Inventory.CountableItem> GetModifiers<T>(this Inventory.Inventory inventory)
			where T : IEntityParameter
		{
			return inventory.GetModifiers(typeof(T));
		}

		public static List<Inventory.Inventory.CountableItem> GetModifiers(this Inventory.Inventory inventory, Type parameterType)
		{
			return inventory.Items.Where(pair => pair.Key.IsSubclassOf(parameterType)).Select(pair => pair.Value).ToList();
		}
	}
}