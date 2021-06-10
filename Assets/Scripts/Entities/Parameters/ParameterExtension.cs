using System;
using ItemSystem.Interfaces.Parameters;
using Parameters.Interfaces;

namespace Entitis.Parameters
{
	public static class ParameterExtension
	{
		public static IEntityParameter<T> GetCopy<T>(this IEntityParameter<T> entityParameter)
		{
			var parameter = Activator.CreateInstance<IEntityParameter<T>>();

			parameter.Value = entityParameter.Value;

			return parameter;
		}
	}
}