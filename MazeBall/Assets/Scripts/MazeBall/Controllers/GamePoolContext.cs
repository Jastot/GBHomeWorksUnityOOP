
using System;

namespace MazeBall
{
    public sealed class GamePoolContext//: IWatchingHealth
    {
        public PlayerModel PlayerModel;

        public void AddPlayerModel(PlayerModel playerModel)
        {
            PlayerModel = playerModel;
        }

        public PlayerModel GetPlayerModel()
        {
            return PlayerModel;
        }
        // public event Action<int> WatchingHealth;
        //
        // public void HeathInvoke()
        // {
        //     PlayerModel.PlayerStruct.Health += health;
        // }
    }
}