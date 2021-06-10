using System;

namespace Parameters.Interfaces
{
	public interface IEntityParameterStorageSetter
	{
		void SetParameter<T>(T parameter) where T : IEntityParameter;
		void SetParameter(Type parameterType, IEntityParameter parameter);
	}
}