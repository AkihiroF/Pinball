
using UnityEngine;

namespace _Source
{
    public class BonusController : ObstaclesController
    {
        public override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
            Destroy(this.gameObject);
        }
    }
}
