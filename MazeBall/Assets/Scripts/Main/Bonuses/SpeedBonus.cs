using UnityEngine;

namespace Main.Bonuses
{


    public sealed class SpeedBonus : BaseBonus
    {
        public float Speed;
        private Player.Player _player;
        
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player.Player>();
            _player.Speed += Speed;
            
        }
    }
}