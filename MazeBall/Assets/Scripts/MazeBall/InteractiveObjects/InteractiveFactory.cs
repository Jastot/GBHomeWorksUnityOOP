
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
            
        // public IInteractive CreateInteractive(InterectiveObjectType type)
        // {
        //     var enemyProvider = _data.GetEnemyOfType(type);
        //     return Object.Instantiate(enemyProvider);
        // }
        public InteractiveData GiveInteractiveData()
        {
            return _data;
        }

        public GameObject CreateInteractiveFromMass(int index)
        {
            // InteractiveProvider enemyProvider = _data.GetEnemyProviderByIndex(index);
            // var InstantiateEnemy = Object.Instantiate(enemyProvider);
            //
            // InstantiateEnemy.transform.position = _positions[index].position;
            // InstantiateEnemy.type = _data.GetEnemyTypeByIndex(index);
            // InstantiateEnemy.index = index;
            //InstantiateEnemy.GetGamePoolContext(_gamePoolContext);
            //return InstantiateEnemy;
            return new GameObject($"{index}").AddMeshFilter(_data._interactiveStructe[index].Mesh).
                AddCubeCollider().AddMeshRenderer(_data._interactiveStructe[index].Material);
        }
        

    }
}