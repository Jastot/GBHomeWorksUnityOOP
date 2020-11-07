using UnityEngine;

namespace MazeBall
{
    

    public sealed class SecondLifeBonus : BaseBonus
    {
        private Player _player;
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _player.heath += Health;
            _displayBonuses.Display(+Point,_player.heath);
        }
    }
}
