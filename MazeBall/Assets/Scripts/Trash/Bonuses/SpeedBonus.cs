using UnityEngine;

namespace MazeBall
{


    public sealed class SpeedBonus : BaseBonus
    {
        public float Speed;
        private Player _player;
        
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _player.speed += Speed;
            
        }
    }
}