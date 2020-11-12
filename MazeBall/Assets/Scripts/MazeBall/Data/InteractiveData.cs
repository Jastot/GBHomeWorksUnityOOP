using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

namespace MazeBall
{
    [CreateAssetMenu(fileName = "BonusSettings", menuName = "Data/Bonus")]
    public class InteractiveData : ScriptableObject
    {
        [Serializable]
        public struct EnemyInfo
        {
            public InterectiveObjectType Type;
            public InteractiveProvider EnemyPrefab;
            private Transform Position;
        }

        [SerializeField] private List<EnemyInfo> _enemyInfos;

        public InteractiveProvider GetEnemyOfType(InterectiveObjectType type)
        {
            var enemyInfo = _enemyInfos.First(info => info.Type == type);
            return enemyInfo.EnemyPrefab;
        }

        public InteractiveProvider GetEnemyProviderByIndex(int index)
        {
            var enemyInfo = _enemyInfos[index];
            return enemyInfo.EnemyPrefab;
        }

        public EnemyInfo GetEnemyInfoByIndex(int index)
        {
            var enemyInfo = _enemyInfos[index];
            return enemyInfo;
        }

        public int GetCountOfMembers()
        {
            return _enemyInfos.Count;
        }
    }
}