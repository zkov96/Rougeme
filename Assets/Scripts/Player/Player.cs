using System.Collections.Generic;
using Entitis.Parameters;
using ItemSystem;
using ItemSystem.Interfaces.Parameters;
using Parameters.Interfaces;

namespace Player
{
	public class Player : BaseMonoPlayer
	{
		public Inventory Inventory => _inventory;
		protected override List<IEntityParameter> Parameters => new List<IEntityParameter>()
		{
			new HPParameter(),
			new DamageParameter()
		};
	}
}