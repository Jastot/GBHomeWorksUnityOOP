using UnityEngine;

namespace MazeBall
{
    public sealed class DoorTrap: IInteraction
    {
        private readonly GamePoolContext _gamePoolContext;

        public DoorTrap(GamePoolContext gamePoolContext)
        {
            _gamePoolContext = gamePoolContext;
        }
        
        public void Interaction()
        {
            Object.Destroy(_gamePoolContext.PlayerModel.PlayerStruct.Player) ;
        }
    }
}