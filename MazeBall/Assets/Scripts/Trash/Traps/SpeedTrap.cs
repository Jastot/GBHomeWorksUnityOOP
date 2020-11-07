using System;

using UnityEngine;

namespace MazeBall
{
    
    public sealed class SpeedTrap : BaseTrap
    {
        public float Speed;
        private Player _player;
        public event EventHandler<PlayersEventArgs> _caughtPlayer;
        public event EventHandler<PlayersEventArgs> CaughtPlayer
        {
            add { _caughtPlayer += value;}
            remove { _caughtPlayer -= value; }
        }
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _player.speed -= Speed; 
            _caughtPlayer?.Invoke(this, new PlayersEventArgs(_color));
            _displayBonuses.Display(+Point, _player.heath);
        }
}
}