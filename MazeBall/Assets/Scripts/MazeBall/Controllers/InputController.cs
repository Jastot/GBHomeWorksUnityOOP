namespace MazeBall
{
    public sealed class InputController : IExecute
    {
        
        private readonly IUserInputs _horizontal;
        private readonly IUserInputs _vertical;
        
        public InputController((IUserInputs inputHorizontal, IUserInputs inputVertical) input)
        {
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
        }
        
        
        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
        }
    }
}