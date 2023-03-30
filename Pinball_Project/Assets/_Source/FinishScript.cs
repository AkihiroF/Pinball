using UnityEngine;

namespace _Source
{
    public class FinishScript : MonoBehaviour
    {
        [SerializeField] private LayerMask layer;
        
        public virtual void OnCollisionEnter(Collision collision)
        {
            if ((layer.value & (1 << collision.gameObject.layer)) > 0)
            {
                EventSystem.InvokeRestart();
            }
        }
    }
}
