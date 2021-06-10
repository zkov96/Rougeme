using ItemSystem.Interfaces;
using ItemSystem.Interfaces.Modificators;
using ItemSystem.Interfaces.Parameters;

namespace ItemSystem
{
	public class HPDamageItem:
		IItem,
		IHPEntityParameterModificator,
		IDamageEntityParameterModificator
	{
		public void Modify(IHPEntityParameter parameter, int count)
		{
			parameter.Value += 10;
		}

		public void Modify(IDamageEntityParameter parameter, int count)
		{
			parameter.Value -= 10;
		}
	}
}