using UnityEngine;

namespace Main.Player
{
    public sealed class MainCamera : MonoBehaviour
    {
        //TODO: отказаться от MonoB
        [SerializeField] private BasePlayer _player;
        private Vector3 _offset;

        private void Start ()
        {
            _offset = transform.position - _player.transform.position;
        }

        private void LateUpdate ()
        {
            transform.position = _player.transform.position + _offset;
        }

    }
}