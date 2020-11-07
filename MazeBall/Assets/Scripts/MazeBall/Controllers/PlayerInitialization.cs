using UnityEngine;

namespace MazeBall
{
    public sealed class PlayerInitialization : IInitialization
    {
        
        private readonly IPlayerFactory _playerFactory;
        private GameObject _player;


        public PlayerInitialization(IPlayerFactory playerFactory, Vector3 startPosition)
        {
            _playerFactory = playerFactory;
            _player = _playerFactory.CreatePlayer();
            _player.transform.position = startPosition;
        }
        
        public void Initialization()
        {
        }

        public Transform GetPlayer()
        {
            return _player.transform;
        }

        public Rigidbody GetPlayersRigidbody()
        {
            return _player.GetComponent<Rigidbody>();
        }
    }
}