using Main;
using UnityEngine;

namespace MazeBall
{
    public class InteractiveProvider: MonoBehaviour,IInteractive
    {
        public int _point = 1;
        public int _health = 5;
        public float Speed = 20;
        private Rigidbody _rigidbody;
        [SerializeField] private InterectiveObjectType _type;
        
        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }
            Debug.Log(_type);
            switch (_type)
            {
                case InterectiveObjectType.Healing:
                    HealingBonus Healunit = new HealingBonus();
                    Healunit.Interaction();
                    break;
                case InterectiveObjectType.SpeedBoost:
                    SpeedBonus Speedunit = new SpeedBonus();
                    Speedunit.Interaction();
                    break;
            }
        }
        
        
    }
}