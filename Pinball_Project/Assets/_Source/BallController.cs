using UnityEngine;

namespace _Source
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private LayerMask interactableLayers;
        [SerializeField] private float mnog;
        private void OnCollisionEnter(Collision collision)
        {
            
        }
    }
}