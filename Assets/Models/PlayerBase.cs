using UnityEngine;


namespace ManRunner
{
    public abstract class PlayerBase : MonoBehaviour
    {
        public float speed = 15.0f;
        public float jumpForce = 200.0f;
        
        
        public abstract void Move(float x, float y);

    }
}