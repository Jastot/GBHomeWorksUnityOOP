using System;
using Main.Player;
using UnityEngine;

namespace Main.Traps
{
    
    public sealed class SpeedTrap : BaseTrap
    {
        public float Speed;
        private Player.Player _player;
        public event EventHandler<PlayersEventArgs> _caughtPlayer;
        public event EventHandler<PlayersEventArgs> CaughtPlayer
        {
            add { _caughtPlayer += value;}
            remove { _caughtPlayer -= value; }
        }
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player.Player>();
            _player.Speed -= Speed; 
            _caughtPlayer?.Invoke(this, new PlayersEventArgs(_color));
            _displayBonuses.Display(+Point, _player.Health);
        }
}
}