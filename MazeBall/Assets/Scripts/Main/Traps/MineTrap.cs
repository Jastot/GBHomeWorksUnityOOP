using UnityEngine;

namespace Main.Traps
{
    internal sealed class MineTrap : BaseTrap
    {
        private Player.Player _player;
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player.Player>();
            _player.Health -= Health;
            if (_player.Health <= 0)
            {
                _view.Display(Point, Health); 
                Destroy(_player);
            }
            else
            {
               _view.Display(Point, Health); 
            }
            
        }
    }
}