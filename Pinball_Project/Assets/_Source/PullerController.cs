using System;
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

        public void Pull()
        {
            body.isKinematic = true;
            var sequence = DOTween.Sequence();
            sequence.Append(body.DOMove(_finishPoint, 4)).AppendCallback(() => body.isKinematic = false);
        }
    }
}
