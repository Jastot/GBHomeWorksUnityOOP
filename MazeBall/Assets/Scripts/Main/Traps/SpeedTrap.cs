using UnityEngine;

namespace Main.Traps
{
   
    
    //да...повтор кода. по-хорошему нужно сделать класс Speed
    //если нужно,то переделаю.
    internal sealed class SpeedTrap : BaseTrap
    {
        public float Speed;
        private Player.Player _player;

        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player.Player>();
            _player.Speed -= Speed; 
            _view.Display(Point, Health);
        }
}
}