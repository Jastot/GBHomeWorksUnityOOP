using System;
using Main;
using UnityEngine;

namespace MazeBall
{
    public abstract class InteractiveObjects : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            Destroy(gameObject);
        }
        
        protected abstract void Interaction();

    }
}