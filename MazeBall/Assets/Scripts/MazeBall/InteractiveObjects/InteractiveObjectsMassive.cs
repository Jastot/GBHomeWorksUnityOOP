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

        public void RemoveUnit(IInteractive unit)
        {
            _interactives.Remove(unit);
        }
    }
}