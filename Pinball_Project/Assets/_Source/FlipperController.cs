using UnityEngine;

namespace _Source
{
    public class FlipperController : MonoBehaviour
    {
        [SerializeField] private Transform finishReference;
        private ConfigurableJoint _joint;
        private Quaternion _startRotation;
        private Quaternion _finishRotation;

        private void Start()
        {
            _startRotation = transform.rotation;
            _finishRotation = finishReference.rotation;
            _joint = GetComponent<ConfigurableJoint>();
        }

        public void TurnFlipper(bool isActive)
        {
            if (isActive)
            {
                _joint.targetRotation = Quaternion.Inverse(_finishRotation) * _startRotation;
            }
            else
            {
                _joint.targetRotation = Quaternion.Inverse(_startRotation);
            }
        }
    }
}