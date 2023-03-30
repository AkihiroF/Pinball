using System;
using UnityEngine;

namespace _Source
{
    public class ObstaclesController : MonoBehaviour
    {
        [SerializeField] private float addingCoin;
        [SerializeField] private LayerMask layerBall;

        public virtual void OnCollisionEnter(Collision collision)
        {
            if ((layerBall.value & (1 << collision.gameObject.layer)) > 0)
            {
                EventSystem.InvokeAdding(addingCoin);
            }
        }
    }
}