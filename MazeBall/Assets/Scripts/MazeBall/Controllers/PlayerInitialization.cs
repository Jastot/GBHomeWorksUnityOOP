using UnityEngine;

namespace MazeBall
{
    public sealed class PlayerInitialization : IInitialization
    {
        
        private readonly IPlayerFactory _playerFactory;
        private GameObject _player;
        public PlayerModel _playerModel { get; }

        public PlayerInitialization(IPlayerFactory playerFactory, Vector3 startPosition)
        {
            _playerFactory = playerFactory;
            _player = _playerFactory.CreatePlayer();
            _player.transform.position = startPosition;
            _playerModel = new PlayerModel(_playerFactory.GivePlayerData());
        }
        
        public void Initialization() { }
        
        public PlayerModel GetPlayerModel()
        {
            return _playerModel;
        }
        public GameObject GetPlayer()
        {
            return _player;
        }

        public Transform GetPlayerTransform()
        {
            return _player.transform;
        }

        public Rigidbody GetPlayersRigidbody()
        {
            return _player.GetComponent<Rigidbody>();
        }
    }
}