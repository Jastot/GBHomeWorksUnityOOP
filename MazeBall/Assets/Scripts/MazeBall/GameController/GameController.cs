
using UnityEngine;
using UnityEngine.UI;

namespace MazeBall
{
    public sealed class GameController : MonoBehaviour
    {
        [SerializeField] private MainData _data;
        [SerializeField] private Transform _startPlayerPosition;
        private Controllers _controllers;
        

        private void Start()
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory(_data.Player);
            var playerInitialization = new PlayerInitialization(playerFactory,_startPlayerPosition.position);
            _controllers = new Controllers();
            _controllers.Add(playerInitialization);
            _controllers.Add(inputInitialization);
            _controllers.Add(new InputController(inputInitialization.GetInput()));
            _controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayersRigidbody(), _data.Player));
            _controllers.Add(new CameraController(playerInitialization.GetPlayer(), camera.transform));
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