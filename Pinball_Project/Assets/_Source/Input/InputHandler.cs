using UnityEngine.InputSystem;

namespace _Source.Input
{
    public class InputHandler
    {
        private PullerController _ballPuller;

        public InputHandler(PullerController pullerController)
        {
            _ballPuller = pullerController;
        }
        public void InputBall(InputAction.CallbackContext obj)
        {
            _ballPuller.Pull();
        }
    }
}