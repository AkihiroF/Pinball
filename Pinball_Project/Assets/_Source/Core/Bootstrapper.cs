using _Source.Input;
using UnityEngine;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PullerController puller;
        
        private void Awake()
        {
            var handler = new InputHandler(puller);
            var game = new Game(new InputManager(), handler);
            game.StartGame();
        }
    }
}
