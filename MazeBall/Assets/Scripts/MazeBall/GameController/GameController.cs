
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MazeBall
{
    public sealed class GameController : MonoBehaviour
    {
        [SerializeField] private MainData _data;
        [SerializeField] private Transform _startPlayerPosition; // по-хорошему должно быть не тут
        [SerializeField] private List<Transform> _BonusAndTrapsPositions; // тоже не тут
        //создать класс PositionDataCreator, который будет создавать лист и прочее из элементов со сцены и уже оттуда брать
        private Controllers _controllers;
        public GamePoolContext _gamePoolContext;
        
        private void Start()
        {
            _gamePoolContext = new GamePoolContext();
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory(_data.Player);
            var playerInitialization = new PlayerInitialization(playerFactory,_gamePoolContext);
            var interactiveFactory = new InteractiveFactory(_data.Bonus,_BonusAndTrapsPositions,_gamePoolContext);
            var interactiveInitialization = new InteractiveInitialization(interactiveFactory,_data.Bonus.GetCountOfMembers());
            
            
            _controllers = new Controllers();
            _controllers.Add(playerInitialization);
            _controllers.Add(inputInitialization);
            _controllers.Add(interactiveInitialization);
            _controllers.Add(new InputController(inputInitialization.GetInput(),_data.Player));
            _controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayersRigidbody(), _data.Player));
            _controllers.Add(new PlayerLifeController(_gamePoolContext));
            _controllers.Add(new CameraController(playerInitialization.GetPlayerTransform(), camera.transform));
            _controllers.Initialization();
        }
        
        private void Update()
        {
            var deltaTime = Time.deltaTime;
            _controllers.Execute(deltaTime);
        }

        private void LateUpdate()
        {
            var deltaTime = Time.deltaTime;
            _controllers.LateExecute(deltaTime);
        }

        private void OnDestroy()
        {
            _controllers.CleanData();
        }
    }
}