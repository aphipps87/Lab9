using UnityEngine;
using CarnivalShooter2D.Observer;

namespace CarnivalShooter2D.Targets
{
    [RequireComponent(typeof(Collider2D))]
    public class Target2D : MonoBehaviour
    {
        public float moveSpeed = 2f;
        public int points = 10;
        public Vector2 moveDir = Vector2.right;
        public float moveAmplitude = 0f; // zig-zag amplitude
        public Vector3 scale = Vector3.one;
        public Color color = Color.white;

        SpriteRenderer sr;

        void Awake()
        {
            sr = GetComponentInChildren<SpriteRenderer>();
            if (sr) sr.color = color;
        }

        void OnEnable()
        {
            transform.localScale = scale;
            if (sr) sr.color = color;
        }

        void Update()
        {
            float dt = Time.deltaTime;
            Vector3 offset = (Vector3)(moveDir.normalized * (moveSpeed * dt));
            if (moveAmplitude > 0f)
                offset += Vector3.up * (Mathf.Sin(Time.time * moveSpeed) * moveAmplitude * dt);
            transform.position += offset;

            // Simple despawn off screen
            if (transform.position.x > 13f || transform.position.x < -13f ||
                transform.position.y > 8f  || transform.position.y < -8f)
            {
                gameObject.SetActive(false);
            }
        }

        public void OnHit()
        {
            // TODO ScoreManager.Instance.AddPoints(points);
            gameObject.SetActive(false);
        }
    }
}
