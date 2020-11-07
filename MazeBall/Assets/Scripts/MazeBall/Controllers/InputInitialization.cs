using UnityEngine.UI;

namespace MazeBall
{
    public class InputInitialization: IInitialization
    {
        private IUserInputs _InputHorizontal;
        private IUserInputs _InputVertical;
        
        public InputInitialization()
        {
            _InputHorizontal = new InputHorizontal();
            _InputVertical = new InputVertical();
        }
        
        public void Initialization()
        { }
        public (IUserInputs inputHorizontal, IUserInputs inputVertical) GetInput()
        {
            (IUserInputs inputHorizontal, IUserInputs inputVertical) result = (_InputHorizontal, _InputVertical);
            return result;
        }
    }
}