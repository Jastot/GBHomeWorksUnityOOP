namespace MazeBall
{
    public sealed class DamageTrap: IInteraction
    {
        private readonly GamePoolContext _gamePoolContext;
        private readonly int _damage;

        public DamageTrap(GamePoolContext gamePoolContext, int damage)
        {
            _gamePoolContext = gamePoolContext;
            _damage = damage;
        }
        
        public void Interaction()
        {
            _gamePoolContext.PlayerModel.PlayerStruct.Health -= _damage;
        }
    }
}