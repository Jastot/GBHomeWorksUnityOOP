using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MazeBall
{
    [CreateAssetMenu(fileName = "BonusSettings", menuName = "Data/Bonus")]
    public class InteractiveData : ScriptableObject
    {
        [Serializable] 
        private struct EnemyInfo
        {
            public InterectiveObjectType Type;
            public InteractiveProvider EnemyPrefab;
        }

        [SerializeField] private List<EnemyInfo> _enemyInfos;

        public InteractiveProvider GetEnemy(InterectiveObjectType type)
        {
            var enemyInfo = _enemyInfos.First(info => info.Type == type);
            return enemyInfo.EnemyPrefab;
        }
    }
}