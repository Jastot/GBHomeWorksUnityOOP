using UnityEngine;

namespace Main.Player
{
    

    public class BasePlayer : MonoBehaviour
    {
        public float Speed = 3.0f;
        public int Health = 1;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Movement()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            
            _rigidbody.AddForce(movement * Speed);
        }
    }
}