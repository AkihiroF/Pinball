using DG.Tweening;
using UnityEngine;

namespace _Source
{
    public class PullerController : MonoBehaviour
    {
        [SerializeField] private Rigidbody body;
        [SerializeField] private Transform maxDistance;

        private Vector3 _finishPoint;
        private void Start()
        {
            _finishPoint = maxDistance.position;
        }

        public void StartPulling()
        {
            body.isKinematic = true;
            body.DOMove(_finishPoint, 4);
        }

        public void Pull()
        {
            body.DOComplete();
            body.isKinematic = false;
        }
    }
}
