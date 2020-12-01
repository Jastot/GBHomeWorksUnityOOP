using System.Collections.Generic;
using Main;
using UnityEngine;

namespace MazeBall
{
    public sealed class InteractiveInitialization: IInitialization
    {
        
        private readonly IInteractiveFactory _interactiveFactory;
        private readonly InteractiveData _data;
        private GameObject _currentEnemy;
        //private InteractiveObjectsMassive _bonus;
        //надо создавать бонусы и пихать их в ГПК

        public InteractiveInitialization(InteractiveFactory interactiveFactory,int dataCount,GamePoolContext gamePoolContext)
        {
            _interactiveFactory = interactiveFactory;
            _data = interactiveFactory.GiveInteractiveData();
            //работает.
            //Object.Destroy(_gamePoolContext.InteractiveModels[1].InteractiveStructe.Enemy);
            //_bonus = new InteractiveObjectsMassive();
            
            
            for (var i=0;i < dataCount;i++)
            {
                //_gamePoolContext.InteractiveModels[i].InteractiveStructe.Enemy = _interactiveFactory.CreateInteractiveFromMass(i);
                _currentEnemy = _interactiveFactory.CreateInteractiveFromMass(i);
                var InteractiveStruct = _data._interactiveStructe;
                _currentEnemy.transform.position = InteractiveStruct[i]._position;
                _currentEnemy.AddComponent<InteractiveProvider>();
                _currentEnemy.GetComponent<InteractiveProvider>().health = _data._interactiveStructe[i].Health;
                _currentEnemy.GetComponent<InteractiveProvider>().speed = _data._interactiveStructe[i].Speed;
                _currentEnemy.GetComponent<InteractiveProvider>().type = _data._interactiveStructe[i].Type;
                _currentEnemy.GetComponent<InteractiveProvider>().positionInList = i;
                InteractiveStruct[i].Enemy = _currentEnemy;
                _currentEnemy.GetComponent<InteractiveProvider>().GetGamePoolContext(gamePoolContext);
                _currentEnemy.AddComponent<RadarObj>();
                _currentEnemy.GetComponent<RadarObj>().enabled = false;
                _currentEnemy.GetComponent<RadarObj>().enabled = true;
                var interactiveCurrentModel = new InteractiveModel(InteractiveStruct[i]);
                gamePoolContext.AddInteractiveModelList(interactiveCurrentModel);
                
                //_bonus.AddUnit(_interactiveFactory.CreateInteractiveFromMass(i));
            }
            
        }
        public void Initialization()
        {
           
        }
    }
}