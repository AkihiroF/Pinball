using _Source.Input;

namespace _Source.Core
{
    public class Game
    {
        public Game(InputManager input, InputHandler inputHandler)
        {
            _input = input;
            _inputHandler = inputHandler;
        }

        private readonly InputManager _input;
        private readonly InputHandler _inputHandler;

        public void StartGame()
        {
            Bind();
        }

        private void Bind()
        {
            _input.Player.Enable();
            _input.Player.PullBall.performed += _inputHandler.InputBall;
        }

        private void UnBind()
        {
            
        }
    }
}