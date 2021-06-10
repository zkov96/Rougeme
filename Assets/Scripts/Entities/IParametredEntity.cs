using ItemSystem.Interfaces.Parameters;
using Parameters.Interfaces;

namespace Entitis
{
	public interface IParametredEntity : IEntity
	{
		void ModifyParameter<T>() where T : IEntityParameter;
	}
}