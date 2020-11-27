using UnityEngine;

namespace MazeBall
{
    public sealed class PlayerInitialization : IInitialization
    {
        
        private readonly IPlayerFactory _playerFactory;
        private GameObject _player;

        public PlayerInitialization(IPlayerFactory playerFactory, GamePoolContext gamePoolContext)
        {
            //тут ссылка на игрока. 
            //отсюда 
            _playerFactory = playerFactory;
            _player = _playerFactory.CreatePlayer();
            var _playerStruct = _playerFactory.GivePlayerData().PlayerStruct;
            _player.transform.position = _playerStruct.StartPosition;
            _playerStruct.Player = _player;
            var _playerComponents = _playerFactory.GivePlayerData().PlayerComponents;
            _playerComponents.Rigitbody = _playerStruct.Player.GetComponent<Rigidbody>();
            
            var playerModel = new PlayerModel(_playerStruct,_playerComponents);
            gamePoolContext.AddPlayerModel(playerModel);
        }
        
        public void Initialization() { }
        
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