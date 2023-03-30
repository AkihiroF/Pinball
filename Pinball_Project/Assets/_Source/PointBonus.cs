using UnityEngine;

namespace _Source
{
    public struct PointBonus
    {
        public PointBonus(Vector3 position, BonusController bonus)
        {
            Position = position;
            Bonus = bonus;
        }
        public Vector3 Position;
        public BonusController Bonus;
    }
}