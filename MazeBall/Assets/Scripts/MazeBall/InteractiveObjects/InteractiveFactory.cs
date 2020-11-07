
using UnityEngine;


namespace MazeBall
{
    public class InteractiveFactory: IInteractiveFactory
    {
        private readonly InteractiveData _data;

        public InteractiveFactory(InteractiveData data)
        {
            _data = data;
        }
            
        public IInteractive CreateInteractive(InterectiveObjectType type)
        {
            var enemyProvider = _data.GetEnemy(type);
            return Object.Instantiate(enemyProvider);
        }
    }
}