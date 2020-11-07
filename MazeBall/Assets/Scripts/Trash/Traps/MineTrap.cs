using System;
using UnityEngine;

namespace MazeBall
{
    public sealed class MineTrap : BaseTrap
    {
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
            
            _player.heath -= Health;
            _caughtPlayer?.Invoke(this, new PlayersEventArgs(_color));
            if (_player.heath <= 0)
            {
                _displayBonuses.Display(Point, _player.heath);
                Destroy(_player);
            }
            else
            {
                _displayBonuses.Display(Point, _player.heath);
            }
            
        }
    }
}