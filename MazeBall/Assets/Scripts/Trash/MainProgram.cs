using System;
using Main;
using UnityEngine;
using UnityEngine.UI;

namespace MazeBall
{
    public sealed class MainProgram : MonoBehaviour, IDisposable
    {
        [SerializeField] private Text _finishGameLabel;
        private ListOfInteractiveObjects _interactiveObjects;
        private DisplayEndGame _displayEndGame;
        
        private void Awake()
        {
            _interactiveObjects = new ListOfInteractiveObjects();
   
            _displayEndGame = new DisplayEndGame(_finishGameLabel);
            foreach (var interactiveObject in _interactiveObjects)
            {
                if (interactiveObject is DoorTrap doorTrap)
                {
                    doorTrap.CaughtPlayer += CaughtPlayer;
                    doorTrap.CaughtPlayer += _displayEndGame.GameOver;
                    doorTrap.CaughtPlayer += delegate (object sender, PlayersEventArgs args) 
                        { Debug.Log($"Вы проиграли. Вас убил {((GameObject) interactiveObject).name} {args.Color} цвета"); };
                }
            }
        }
        
        private void CaughtPlayer(object value, PlayersEventArgs args)
        {
            Time.timeScale = 0.0f;
        }

        public void Dispose()
        {
            foreach (var o in _interactiveObjects)
            {
                if (o is InteractiveObject interactiveObject)
                {
                    if (o is DoorTrap doorTrap)
                    {
                        doorTrap.CaughtPlayer -= CaughtPlayer;
                        doorTrap.CaughtPlayer -= _displayEndGame.GameOver;
                    }
                    Destroy(interactiveObject.gameObject);
                }
                
            }
        }
        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }

                if (interactiveObject is IFlay flay)
                {
                    flay.Flay();
                }
                if (interactiveObject is IFlicker flicker)
                {
                    flicker.Flicker();
                }
                if (interactiveObject is IRotation rotation)
                {
                    rotation.Rotation();
                }
                
            }

        }

    }
}