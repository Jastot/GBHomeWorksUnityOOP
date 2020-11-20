using UnityEngine;

namespace MazeBall
{
    public sealed class InputController : IExecute
    {
        
        private readonly IUserInputs _horizontal;
        private readonly IUserInputs _vertical;  
        private readonly PlayerData _playerBase;
        private readonly SaveDataRepository _saveDataRepository;
        private readonly KeyCode _savePlayer = KeyCode.C;
        private readonly KeyCode _loadPlayer = KeyCode.V;
        
        public InputController((IUserInputs inputHorizontal, IUserInputs inputVertical) input,PlayerData player)
        {
            _playerBase = player;
            
            _saveDataRepository = new SaveDataRepository();
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
        }
        
        
        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
            if (Input.GetKeyDown(_savePlayer))
            {
                _saveDataRepository.Save(_playerBase);
            }
            if (Input.GetKeyDown(_loadPlayer))
            {
                _saveDataRepository.Load(_playerBase);
            }
        }
    }
}