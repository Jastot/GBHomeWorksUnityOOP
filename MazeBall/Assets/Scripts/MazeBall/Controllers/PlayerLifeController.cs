using UnityEngine;

namespace MazeBall
{
    public class PlayerLifeController: IExecute
    {
        private readonly GamePoolContext _gamePoolContext;
        private readonly IWatchingHealth _watchingHealth;
        private int _health;
        
        public PlayerLifeController(GamePoolContext gamePoolContext)
        {
            _gamePoolContext = gamePoolContext;
            _health = _gamePoolContext.PlayerModel.PlayerStruct.Health;
            //_watchingHealth.WatchingHealth += HealthChange;
        }

        private void HealthChange(int value)
        {
            _health = value;
        }
        public void Execute(float deltaTime)
        {
            //Debug.Log("Current "+_health);
            if (_health == 0)
            { 
                Object.Destroy(_gamePoolContext.PlayerModel.PlayerStruct.Player);
            }
        }
        // public void CleanData() 
        // {
        //     _watchingHealth.WatchingHealth -= HealthChange; 
        // }
    }
}