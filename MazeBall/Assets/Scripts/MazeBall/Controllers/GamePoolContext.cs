
using System;
using System.Collections.Generic;

namespace MazeBall
{
    public sealed class GamePoolContext//: IWatchingHealth
    {
        public PlayerModel PlayerModel;
        public List<InteractiveModel> InteractiveModels;

        public GamePoolContext()
        {
            InteractiveModels = new List<InteractiveModel>();
        }

        public void AddPlayerModel(PlayerModel playerModel)
        {
            PlayerModel = playerModel;
        }

        public void AddInteractiveModelList(InteractiveModel interactiveModel)
        {
            InteractiveModels.Add(interactiveModel);
        }

        public void RemoveInteractiveModelList(int index)
        {
            InteractiveModels.RemoveAt(index);
        }
        
        // public PlayerModel GetPlayerModel()
        // {
        //     return PlayerModel;
        // }
    }
}