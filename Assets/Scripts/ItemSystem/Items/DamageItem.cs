using ItemSystem.Interfaces;
using ItemSystem.Interfaces.Modificators;
using ItemSystem.Interfaces.Parameters;

namespace ItemSystem
{
	public class DamageItem: IItem, IDamageEntityParameterModificator
	{
		public void Modify(IDamageEntityParameter parameter, int count)
		{
			parameter.Value += 1;
		}
	}
}