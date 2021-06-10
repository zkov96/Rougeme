using System;
using System.Collections.Generic;
using System.Linq;
using Entitis;
using ItemSystem;
using ItemSystem.Interfaces.Modificators;
using Parameters.Interfaces;
using UnityEngine;

namespace Player
{
	public abstract class BaseMonoPlayer : MonoBehaviour, IPlayer
	{
		protected Inventory.Inventory _inventory;
		protected abstract List<IEntityParameter> Parameters { get; }

		private Dictionary<Type, IEntityParameter> _parametersDict = new Dictionary<Type, IEntityParameter>();

		public void Init()
		{
			_parametersDict = Parameters.ToDictionary(parameter => parameter.GetType());
		}

		public void ModifyParameter<T>() where T : IEntityParameter
		{
			ModifyParameter(typeof(T));
		}

		private void ModifyParameter(Type parameterType)
		{
			if (!_parametersDict.ContainsKey(parameterType))
			{
				return;
			}

			var countableItems = _inventory.GetModifiers(parameterType);
			foreach (var countableItem in countableItems)
			{
				_parametersDict[parameterType].Modify(
					(IEntityParameterModificator) countableItem.ItemParameterModificator,
					countableItem.Count
				);
			}
		}
	}
}