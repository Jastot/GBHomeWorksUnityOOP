using UnityEngine;

namespace Main.Traps
{
    internal sealed class DoorTrap : BaseTrap
    {
        private Object _player;
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player");
            _view.Display(Point, Health); 
            Destroy(_player);
        }
    }
}