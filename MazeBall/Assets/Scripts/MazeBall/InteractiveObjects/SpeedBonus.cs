using UnityEngine;

namespace MazeBall
{
    public sealed class SpeedBonus : InteractiveProvider, IBonusOrTrap
    {
        private Player _player;

        public void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _player.speed += Speed;
            
        }
    }
}