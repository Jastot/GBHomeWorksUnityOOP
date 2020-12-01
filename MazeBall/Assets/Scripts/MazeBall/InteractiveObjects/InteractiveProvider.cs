using UnityEngine;
//using Object = UnityEngine.Object;

namespace MazeBall
{
    public class InteractiveProvider: MonoBehaviour,IInteractive
    {
        public GamePoolContext _gamePoolContext;
        public InterectiveObjectType type;
        public int point = 1;
        public int health = 5;
        public float speed = 20;
        public int positionInList;
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(_gamePoolContext.InteractiveModels[positionInList]);
            if (!other.CompareTag("Player"))
            {
                return;
            }
            switch (type)
            {
                case InterectiveObjectType.Healing:
                    HealingBonus healunit = new HealingBonus(_gamePoolContext,health);
                    healunit.Interaction();
                    break;
                case InterectiveObjectType.SpeedBoost:
                    SpeedBonus speedunit = new SpeedBonus(_gamePoolContext,speed);
                    speedunit.Interaction();
                    break;
                case InterectiveObjectType.DamageTrap:
                    DamageTrap damageTrap = new DamageTrap(_gamePoolContext,health);
                    damageTrap.Interaction();                 
                    break;
                case InterectiveObjectType.DoorTrap:
                    DoorTrap doorTrap = new DoorTrap(_gamePoolContext);
                    doorTrap.Interaction();
                    break;
                case InterectiveObjectType.SpeedTrap:
                    SpeedTrap speedTrap = new SpeedTrap(_gamePoolContext,speed);
                    speedTrap.Interaction();
                    break;
            }
            //Debug.Log(_gamePoolContext.InteractiveModels[positionInList].InteractiveStructe.Enemy);
            
            //нужно уничтожение
            Object.Destroy(_gamePoolContext.InteractiveModels[positionInList].InteractiveStructe.Enemy);
            //Debug.Log(_gamePoolContext.InteractiveModels[positionInList].InteractiveStructe.Enemy);

        }

         public void GetGamePoolContext(GamePoolContext gamePoolContext)
        {
             _gamePoolContext = gamePoolContext;
        }

    }
}