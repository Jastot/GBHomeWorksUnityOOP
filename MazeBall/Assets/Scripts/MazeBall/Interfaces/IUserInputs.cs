using System;

namespace MazeBall
{
    public interface IUserInputs
    {
        event Action<float> AxisOnChange;
        void GetAxis();
    }
}