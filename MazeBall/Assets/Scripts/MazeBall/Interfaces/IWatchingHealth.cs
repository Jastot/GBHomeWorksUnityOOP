using System;

namespace MazeBall
{
    public interface IWatchingHealth
    {
        event Action<int> WatchingHealth;
        

        void HeathInvoke();

    }
}