using System;
using UnityEngine;

namespace _Source
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private LayerMask interactableLayers;
        [SerializeField] private float mnog;
        private Rigidbody _rb;
        private Vector3 _startPosition;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            EventSystem.OnRestart += Restart;
            _startPosition = transform.position;
        }

        private void Restart()
        {
            transform.position = _startPosition;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if ((interactableLayers.value & (1 << collision.gameObject.layer)) > 0)
            {
                Transform transform1;
                (transform1 = transform).forward = Vector3.Reflect(collision.contacts[0].point, collision.contacts[0].normal);
                _rb.velocity = transform1.forward * mnog;
            }
        }
    }
}