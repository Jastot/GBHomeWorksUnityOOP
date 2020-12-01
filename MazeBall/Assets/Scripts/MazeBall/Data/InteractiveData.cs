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
        public List<InteractiveStructe> _interactiveStructe;
        
        // [Serializable]
        // public struct EnemyInfo
        // {
        //     public InterectiveObjectType Type;
        //     public InteractiveProvider EnemyPrefab;
        //     public PlayerModel Target;
        //     private Transform _position;
        //     
        // }

        // [SerializeField] private List<EnemyInfo> _enemyInfos;

        // public InteractiveProvider GetEnemyOfType(InterectiveObjectType type)
        // {
        //     var enemyInfo = _interactiveStructe.First(info => info.Type == type);
        //     return enemyInfo.EnemyPrefab;
        // }

        // public InteractiveProvider GetEnemyProviderByIndex(int index)
        // {
        //     var enemyInfo = _interactiveStructe[index];
        //     return enemyInfo.EnemyPrefab;
        // }

        public PlayerModel SetTargetByIndex(int index, PlayerModel model)
        {
            var enemyinfo = _interactiveStructe[index];
            enemyinfo.Target = model;
            return enemyinfo.Target;
        }
        public InterectiveObjectType GetEnemyTypeByIndex(int index)
        {
            var enemyInfo = _interactiveStructe[index];
            return enemyInfo.Type;
        }
        public InteractiveStructe GetEnemyInfoByIndex(int index)
        {
            var enemyInfo = _interactiveStructe[index];
            return enemyInfo;
        }

        public int GetCountOfMembers()
        {
            return _interactiveStructe.Count;
        }
    }
}