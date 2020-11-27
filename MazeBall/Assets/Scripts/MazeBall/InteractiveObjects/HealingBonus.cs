using UnityEngine;

namespace MazeBall
{
    public sealed class HealingBonus
    {
        private readonly GamePoolContext _gamePoolContext;

        public HealingBonus(GamePoolContext gamePoolContext)
        {
            _gamePoolContext = gamePoolContext;
            Debug.Log(_gamePoolContext);
        }
        public void Interaction(int heal)
        {
            _gamePoolContext.PlayerModel.PlayerStruct.Health += heal;
        }
    }
}