using UnityEngine;
using CarnivalShooter2D.Targets;

namespace CarnivalShooter2D.Builders
{
    public class MediumTargetBuilder : TargetBuilder
    {
        public MediumTargetBuilder()
        {
            speed = 3.5f;   // medium
            pts = 20;     // moderate score
            scl = Vector3.one * 1.1f; // medium size
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
