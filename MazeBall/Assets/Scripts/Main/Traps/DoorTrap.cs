using System;
using Main.Player;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Main.Traps
{
    public sealed class DoorTrap : BaseTrap
    {
        private Object _player;
        public event EventHandler<PlayersEventArgs> _caughtPlayer;
        public event EventHandler<PlayersEventArgs> CaughtPlayer
        {
            add { _caughtPlayer += value;}
            remove { _caughtPlayer -= value; }
        }
        protected override void Interaction()
        {
            _player = GameObject.FindGameObjectWithTag("Player");
            Destroy(_player);
            _caughtPlayer?.Invoke(this, new PlayersEventArgs(_color));
        }
    }
}