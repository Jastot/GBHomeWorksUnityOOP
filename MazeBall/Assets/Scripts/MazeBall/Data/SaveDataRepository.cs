using System.IO;
using UnityEngine;


namespace MazeBall
{
    public class SaveDataRepository
    {
        private readonly IData<SavedData> _data;

        private const string _folderName = "dataSave";
        private const string _fileName = "data.bat";
        private readonly string _path;

        public SaveDataRepository()
        {
            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
                _data = new PlayerPrefsData();
            }
            else
            {
                _data = new JsonData<SavedData>();
            }
            _path = Path.Combine(Application.dataPath, _folderName);
            
        }

        public void Save(PlayerData player)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }
            var savePlayer = new SavedData
            {
                Position = player.PlayerStruct.StartPosition,
                Name = "SuperPlayer"
            };

            _data.Save(savePlayer, Path.Combine(_path, _fileName));
        }

        public void Load(PlayerData player)
        {
            var file = Path.Combine(_path, _fileName);
            if (!File.Exists(file)) return;
            var newPlayer = _data.Load(file);
            player.PlayerStruct.StartPosition = newPlayer.Position;
            player.name = newPlayer.Name;
        }
    }
}