using System;

namespace Parameters.Interfaces
{
	public interface IEntityParameterStorageGetter
	{
		T GetParameter<T>() where T : IEntityParameter;
		IEntityParameter GetParameter(Type parameterType);
	}
}