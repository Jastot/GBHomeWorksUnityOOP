using System;
using UnityEngine;

namespace Main.Player
{
    public sealed class PlayersEventArgs:EventArgs
    {
        public Color Color { get; }

        public PlayersEventArgs(Color Color)
        {
            Color = Color;
        }
    }
}