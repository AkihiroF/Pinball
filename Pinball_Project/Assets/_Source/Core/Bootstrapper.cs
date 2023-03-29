using _Source.Input;
using UnityEngine;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PullerController puller;
        [SerializeField] private FlipperController leftFlipper;
        [SerializeField] private FlipperController rightFlipper;
        
        private void Awake()
        {
            var handler = new InputHandler(puller, rightFlipper,leftFlipper);
            var game = new Game(new InputManager(), handler);
            game.StartGame();
        }
    }
}
