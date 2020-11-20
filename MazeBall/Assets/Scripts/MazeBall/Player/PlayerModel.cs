
using System;
using System.Collections;
using System.Data;
using UnityEngine;

namespace MazeBall
{
    public sealed class PlayerModel : IWatchingHealth
    {
        private readonly float _speed;
        public  int _health;
        private readonly int _maxScore;
        
        public event Action<int> WatchingHealth= delegate(int i) { };
        public event Action<int> WatchingPoints= delegate(int i) { };
        public event Action<float> WatchingSpeed= delegate(float f) { };
        
        public void GetHeath()
        {
            WatchingHealth.Invoke(_health);
        }

        public void GetSpeed()
        {
            WatchingSpeed.Invoke(_speed);
        }

        public void GetPoints()
        {
            WatchingPoints.Invoke(_maxScore);
        }

        public PlayerModel(PlayerData playerData)
        {
            _speed = playerData.Speed;
            _health = playerData.Heath;
            _maxScore = playerData.MaxPoints;
        }

        
    }
}