using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace _Source
{
    public class SpawnerBonus : MonoBehaviour
    {
        [SerializeField] private float timeRespawn;
        [SerializeField] private List<Transform> points;
        [SerializeField] private GameObject bigBonus;
        [SerializeField] private GameObject littleBonus;
        
        private List<PointBonus> _points;

        private void Start()
        {
            _points = new List<PointBonus>();
            foreach (var point in points)
            {
                var isBig = Random.Range(0, 2) == 0;
                var position = point.position;
                if (isBig)
                {
                    var bonus = SpawnObjects(bigBonus, position);
                    _points.Add(new PointBonus(position, bonus));
                }
                else
                {
                    var bonus = SpawnObjects(littleBonus, position);
                    _points.Add(new PointBonus(position, bonus));
                }
            }
            StartCoroutine(Wait());
        }

        private void RespawnBonus()
        {
            for (int i = 0; i < _points.Count; i++)
            {
                var point = _points[i];
                if (point.Bonus)
                {
                    continue;
                }
                var isBig = Random.Range(0, 2) == 0;
                var position = point.Position;
                if (isBig)
                {
                    var bonus = SpawnObjects(bigBonus, position);
                    _points[i] = new PointBonus(position, bonus);
                }
                else
                {
                    var bonus = SpawnObjects(littleBonus, position);
                    _points[i] = new PointBonus(position, bonus);
                }
            }
            StartCoroutine(Wait());
        }

        private BonusController SpawnObjects(GameObject pointPrefab, Vector3 position)
        {
            return Instantiate(pointPrefab, position, Quaternion.identity).GetComponent<BonusController>();
        }

        private IEnumerator Wait()
        {
            yield return new WaitForSeconds(timeRespawn);
            RespawnBonus();
        }
    }
}