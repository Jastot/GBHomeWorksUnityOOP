using UnityEngine;
using System.IO;

namespace MazeBall
{
    [CreateAssetMenu(fileName = "MainData", menuName = "Data/MainData")]
    public sealed class MainData: ScriptableObject
    {
        [SerializeField] private string _playerDataPath;
        [SerializeField] private string _bonusDataPath;
        private PlayerData _player;
        private InteractiveData _bonus;

        public PlayerData Player
        {
            get
            {
                if (_player == null)
                {
                    _player = Load<PlayerData>("Data/" + _playerDataPath);
                }

                return _player;
            }
        }
    
        public InteractiveData Bonus
        {
            get
            {
                if (_bonus == null)
                {
                    _bonus = Load<InteractiveData>("Data/" + _bonusDataPath);
                }

                return _bonus;
            }
        }
        
        private T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));


    }
}