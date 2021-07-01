using UnityEngine;


namespace ManRunner
{
    public class InputController : IExecute
    {
        private readonly PlayerBase _playerBase;
        
        public InputController(PlayerBase player)
        {
            _playerBase = player;
        }
        public void Execute()
        {
            _playerBase.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}