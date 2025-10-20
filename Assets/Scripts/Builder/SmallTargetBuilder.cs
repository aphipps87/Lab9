using UnityEngine;
using CarnivalShooter2D.Targets;

namespace CarnivalShooter2D.Builders
{
    public class SmallTargetBuilder : TargetBuilder
    {
        public SmallTargetBuilder()
        {
            speed = 5f;     // fast
            pts = 40;     // high score
            scl = Vector3.one * 0.8f; // small
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
