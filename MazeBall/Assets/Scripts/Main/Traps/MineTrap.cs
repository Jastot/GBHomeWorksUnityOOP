using System;
using Main.Player;
using UnityEngine;

namespace Main.Traps
{
    public sealed class MineTrap : BaseTrap
    {
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
            _player.Health -= Health;
            _caughtPlayer?.Invoke(this, new PlayersEventArgs(_color));
            if (_player.Health <= 0)
            {
                _displayBonuses.Display(Point, _player.Health);
                Destroy(_player);
            }
            else
            {
                _displayBonuses.Display(Point, _player.Health);
            }
            
        }
    }
}