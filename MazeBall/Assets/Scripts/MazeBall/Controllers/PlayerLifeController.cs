using UnityEngine;

namespace MazeBall
{
    public class PlayerLifeController: IExecute, ICleanData
    {
        private readonly PlayerModel _playerModel;
        private readonly IWatchingHealth _watchingHealth;
        private GameObject _player;
        private int _health;
        
        public PlayerLifeController(PlayerData data ,PlayerModel model)
        {
            _health = data.Heath;
            _watchingHealth = model;
            _watchingHealth.WatchingHealth += HealthChange;
            _player = GameObject.FindGameObjectWithTag("Player");
           
        }

        private void HealthChange(int value)
        {
            _health = value;
        }
        public void Execute(float deltaTime)
        {
            if (_health == 0)
            {
                Object.Destroy(_player);
            }
        }
        public void CleanData() 
        {
            _watchingHealth.WatchingHealth -= HealthChange; 
        }
    }
}