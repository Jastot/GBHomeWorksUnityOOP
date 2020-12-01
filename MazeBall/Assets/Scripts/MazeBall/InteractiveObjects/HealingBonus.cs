using UnityEngine;

namespace MazeBall
{
    public sealed class HealingBonus : IInteraction
    {
        private readonly GamePoolContext _gamePoolContext;
        private readonly int _heal;

        public HealingBonus(GamePoolContext gamePoolContext,int heal)
        {
            _gamePoolContext = gamePoolContext;
            _heal = heal;
        }
        public void Interaction()
        {
            _gamePoolContext.PlayerModel.PlayerStruct.Health += _heal;
        }
    }
}