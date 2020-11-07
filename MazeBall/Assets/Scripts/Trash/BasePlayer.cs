using UnityEngine;

namespace MazeBall
{
    public class BasePlayer : MonoBehaviour
    {
        public float speed;
        public int heath;
        private Rigidbody _rigidbody;
        private Transform _transform;
        
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Movement()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            
            _rigidbody.AddForce(movement * speed);
        }
    }
}