using UnityEngine;

namespace MazeBall
{
    public sealed class HealingBonus : InteractiveProvider, IBonusOrTrap
    {
        
        private Player _player;

        public void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _player.heath += _health;
            
        }
    }
}