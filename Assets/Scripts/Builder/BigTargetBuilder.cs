using UnityEngine;
using CarnivalShooter2D.Targets;

namespace CarnivalShooter2D.Builders
{
    public class BigTargetBuilder : TargetBuilder
    {
        public BigTargetBuilder()
        {
            speed = 1.8f;   // slow
            pts = 10;     // low score
            scl = Vector3.one * 1.5f; // big
        }

        public override Target2D Build(Transform parent)
        {
            var go = Object.Instantiate(prefab, spawnPos, Quaternion.identity, parent);
            var t = go.GetComponent<Target2D>();
            t.moveSpeed = speed;
            t.points = pts;
            t.moveDir = dir;
            t.scale = scl;
            return t;
        }
    }
}
