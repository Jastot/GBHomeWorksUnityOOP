using UnityEngine;

namespace MazeBall
{
    public sealed class PlayerFactory: IPlayerFactory
    {
        
        private readonly PlayerData _playerData;

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }
        
        public GameObject CreatePlayer()
        {
            return new GameObject("Player").
                AddRigidbody(1).AddMeshFilter(_playerData.PlayerStruct.Mesh).AddMeshRenderer(_playerData.PlayerStruct.Material)
                .AddSphereCollider().AddTag("Player");
        }

        public PlayerData GivePlayerData()
        {
            return _playerData;
        }
    }
}