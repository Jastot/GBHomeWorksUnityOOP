using System.Collections.Generic;
using UnityEngine;

namespace MazeBall
{
    public class InteractiveObjectsMassive :IInteractive
    {
        private List<IInteractive> _interactives = new List<IInteractive>();
        
        public void AddUnit(IInteractive unit)
        {
            _interactives.Add(unit);
        }

        public void RemoveUnit(int unit)
        {
            _interactives.RemoveAt(unit);
        }

        public IInteractive GiveMeObjOfCurrent(int index)
        {
           return _interactives[index];
        }
    }
}