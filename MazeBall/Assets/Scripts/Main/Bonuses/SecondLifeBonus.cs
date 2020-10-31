using UnityEngine;

namespace Main.Bonuses
{
    

    public sealed class SecondLifeBonus : BaseBonus
    {
        private Player.Player _player;
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player.Player>();
            _player.Health += Health;
            _displayBonuses.Display(+Point,_player.Health);
        }
    }
}
