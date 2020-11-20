
using System.Collections.Generic;
using UnityEngine;


namespace MazeBall
{
    public class InteractiveFactory: IInteractiveFactory
    {
        private readonly InteractiveData _data;
        private readonly List<Transform> _positions;
        private readonly PlayerModel _playerData;

        public InteractiveFactory(InteractiveData data, List<Transform> positions, PlayerModel playerData)
        {
            _data = data;
            _positions = positions;
            _playerData = playerData;
        }
            
        public IInteractive CreateInteractive(InterectiveObjectType type)
        {
            var enemyProvider = _data.GetEnemyOfType(type);
            return Object.Instantiate(enemyProvider);
        }

        public IInteractive CreateInteractiveFromMass(int index)
        {
            InteractiveProvider enemyProvider = _data.GetEnemyProviderByIndex(index);
            enemyProvider.transform.position = _positions[index].position;
            enemyProvider._type = _data.GetEnemyTypeByIndex(index);
            enemyProvider._PlayerModel = _playerData;
            return Object.Instantiate(enemyProvider);
        }
    }
}