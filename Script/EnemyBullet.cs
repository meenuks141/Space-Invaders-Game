using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        transform.Translate(
            Vector2.down * speed * Time.deltaTime
        );

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}