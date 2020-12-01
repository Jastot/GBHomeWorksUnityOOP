using UnityEngine;

namespace MazeBall
{
    public sealed class SpeedBonus : IInteraction
    {
        private readonly GamePoolContext _gamePoolContext;
        private readonly float _speed;

        public SpeedBonus(GamePoolContext gamePoolContext,float speed)
        {
            _gamePoolContext = gamePoolContext;
            _speed = speed;
        }

        public void Interaction()
        {
            _gamePoolContext.PlayerModel.PlayerStruct.Speed += _speed;
        }

        
    }
}