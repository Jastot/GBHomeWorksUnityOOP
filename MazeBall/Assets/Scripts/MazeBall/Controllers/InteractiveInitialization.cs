using System.Collections.Generic;
using Main;
using UnityEngine;

namespace MazeBall
{
    public class InteractiveInitialization: IInitialization
    {
        
        private readonly IInteractiveFactory _interactiveFactory;
        private InteractiveObjectsMassive _bonus;
       

        public InteractiveInitialization(IInteractiveFactory interactiveFactory,int dataCount)
        {
            _interactiveFactory = interactiveFactory;
            _bonus = new InteractiveObjectsMassive();
            for (var i=0;i < dataCount;i++)
            {
                _bonus.AddUnit(_interactiveFactory.CreateInteractiveFromMass(i));
            }
        }
        public void Initialization()
        {
           
        }
    }
}