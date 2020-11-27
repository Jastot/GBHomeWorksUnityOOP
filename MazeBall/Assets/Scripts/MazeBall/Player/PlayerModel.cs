
using System;
using System.Collections;
using System.Data;
using UnityEngine;

namespace MazeBall
{
    public sealed class PlayerModel 
    {
        public PlayerStruct PlayerStruct;
        public PlayerComponents PlayerComponents;

        public PlayerModel(PlayerStruct playerStruct,PlayerComponents playerComponents)
        {
            PlayerStruct = playerStruct;
            PlayerComponents = playerComponents;
        }
        
    }
}