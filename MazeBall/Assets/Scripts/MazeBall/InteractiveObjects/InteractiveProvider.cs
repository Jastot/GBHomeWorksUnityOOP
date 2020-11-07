using Main;
using UnityEngine;

namespace MazeBall
{
    public class InteractiveProvider: MonoBehaviour,IInteractive
    {
        [SerializeField] private int _point;
        [SerializeField] private int _health;
        [SerializeField] private float _speed;
        private Player _player;
        private Rigidbody _rigidbody;
        private Transform _transform;
 
        public void Start()
        {
         _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }
            
            
        }
        
        
    }
}