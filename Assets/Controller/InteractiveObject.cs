using System;
using UnityEngine;

namespace ManRunner
{
    public abstract class InteractiveObject : MonoBehaviour, IExecute
    {
        private bool _isInteractable;

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            
            IsInteractable = false;
        }
        
        protected bool IsInteractable
        {
            get { return _isInteractable; }
            private set
            {
                _isInteractable = value;
                GetComponent<Collider2D>().enabled = _isInteractable;
            }
        }
        
        public abstract void Execute();
    }
}