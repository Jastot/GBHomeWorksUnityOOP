using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace MazeBall
{
    public class InteractiveProvider: MonoBehaviour,IInteractive
    {
        public GamePoolContext _gamePoolContext;
        public InterectiveObjectType type;
        public int point = 1;
        public int health = 5;
        public float speed = 20;

        private void OnTriggerEnter(Collider other)
        {
            
            Debug.Log(_gamePoolContext);

            if (!other.CompareTag("Player"))
            {
                return;
            }
            switch (type)
            {
                case InterectiveObjectType.Healing:
                   // HealingBonus healunit = new HealingBonus(_gamePoolContext);
                   // healunit.Interaction(health);
                    break;
                case InterectiveObjectType.SpeedBoost:
                    // SpeedBonus speedunit = new SpeedBonus();
                    // speedunit.Interaction(_PlayerModel,speed);
                    break;
            }
        }

         public void GetGamePoolContext(GamePoolContext gamePoolContext)
        {
             _gamePoolContext = gamePoolContext;
         }

    }
}