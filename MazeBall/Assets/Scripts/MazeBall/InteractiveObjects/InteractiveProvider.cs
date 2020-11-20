using UnityEngine;
using UnityEngine.Serialization;

namespace MazeBall
{
    public class InteractiveProvider: MonoBehaviour,IInteractive
    {
        public InterectiveObjectType _type;
        public int point = 1;
        public int health = 5;
        public float speed = 20;
        public PlayerModel _PlayerModel;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }
            switch (_type)
            {
                case InterectiveObjectType.Healing:
                    HealingBonus healunit = new HealingBonus();
                    healunit.Interaction(_PlayerModel,health);
                    break;
                case InterectiveObjectType.SpeedBoost:
                    // SpeedBonus speedunit = new SpeedBonus();
                    // speedunit.Interaction(_PlayerModel,speed);
                    break;
            }
        }
        
        
    }
}