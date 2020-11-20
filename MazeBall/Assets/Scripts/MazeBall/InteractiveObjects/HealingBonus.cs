using UnityEngine;

namespace MazeBall
{
    public sealed class HealingBonus
    {
        public void Interaction(PlayerModel playerModel,int heal)
        {
            playerModel._health += heal;
        }
    }
}