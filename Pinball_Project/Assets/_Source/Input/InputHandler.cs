using System;
using UnityEngine.InputSystem;

namespace _Source.Input
{
    public class InputHandler
    {
        private readonly PullerController _ballPuller;
        private FlipperController _rightFlipper;
        private FlipperController _leftFlipper;

        public InputHandler(PullerController pullerController, FlipperController rightFlipper, FlipperController leftFlipper)
        {
            _ballPuller = pullerController;
            _leftFlipper = leftFlipper;
            _rightFlipper = rightFlipper;
        }
        public void InputBall(InputAction.CallbackContext obj)
        {
            var isPress = Math.Abs(obj.ReadValue<float>() - 1) < 1;   
            if(isPress)
                _ballPuller.StartPulling();
            else
                _ballPuller.Pull();
        }

        public void InputLeftFlipper(InputAction.CallbackContext obj)
        {
            var isPress = Math.Abs(obj.ReadValue<float>() - 1) < 1; 
            _leftFlipper.TurnFlipper(isPress);
        }

        public void InputReghtFlipper(InputAction.CallbackContext obj)
        {
            var isPress = Math.Abs(obj.ReadValue<float>() - 1) < 1; 
            _rightFlipper.TurnFlipper(isPress);
        }
    }
}