
using System.Collections.Generic;
using UnityEngine;


namespace MazeBall
{
    public class InteractiveFactory: IInteractiveFactory
    {
        private readonly InteractiveData _data;
        private readonly List<Transform> _positions;
        public GamePoolContext _gamePoolContext;

        public InteractiveFactory(InteractiveData data, List<Transform> positions, GamePoolContext gamePoolContext)
        {
            _data = data;
            _positions = positions;
            _gamePoolContext = gamePoolContext;
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
            enemyProvider.type = _data.GetEnemyTypeByIndex(index);
            enemyProvider.GetGamePoolContext(_gamePoolContext);
     
            return Object.Instantiate(enemyProvider);
        }
    }
}