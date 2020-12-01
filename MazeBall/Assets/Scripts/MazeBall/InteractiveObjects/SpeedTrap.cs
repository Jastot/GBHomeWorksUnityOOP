namespace MazeBall
{
    public sealed class SpeedTrap: IInteraction
    {
        private readonly GamePoolContext _gamePoolContext;
        private readonly float _speed;

        public SpeedTrap(GamePoolContext gamePoolContext, float speed)
        {
            _gamePoolContext = gamePoolContext;
            _speed = speed;
        }
        
        public void Interaction()
        {
            _gamePoolContext.PlayerModel.PlayerStruct.Speed -= _speed;
        }
    }
}