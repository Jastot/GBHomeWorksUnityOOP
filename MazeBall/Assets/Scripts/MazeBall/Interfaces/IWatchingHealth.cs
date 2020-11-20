using System;

namespace MazeBall
{
    public interface IWatchingHealth
    {
        event Action<int> WatchingHealth;

        event Action<int> WatchingPoints;

        event Action<float> WatchingSpeed;

        void GetHeath();
        void GetSpeed();
        void GetPoints();
    }
}