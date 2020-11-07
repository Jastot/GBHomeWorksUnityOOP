using UnityEngine;

namespace MazeBall
{
    public interface IPlayerStats
    {
        float Speed { get; }
        int MaxPoints { get; } 
        int Heath { get; }

    }
}