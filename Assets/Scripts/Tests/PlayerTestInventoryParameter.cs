using ItemSystem;
using UnityEngine;

namespace Tests
{
	public class PlayerTestInventoryParameter : MonoBehaviour
	{
		[SerializeField] private Player.Player _player;

		public void AddHPItem()
		{
			_player.Inventory.ChangeItem<HPItem>();
		}
		
		public void AddDamageItem()
		{
			_player.Inventory.ChangeItem<DamageItem>();
		}
		
		public void AddHPDamageItem()
		{
			_player.Inventory.ChangeItem<HPDamageItem>();
		}

		public void CalculateModifiers()
		{
			_player.ModifyParameter<>();
		}
	}
}