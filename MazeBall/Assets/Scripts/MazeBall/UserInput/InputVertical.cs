using System;
using UnityEngine;

namespace MazeBall
{
    public class InputVertical: IUserInputs
    {
        public event Action<float> AxisOnChange = delegate(float f) {  };
        
        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis(AxisManager.VERTICAL));
        }
    }
}