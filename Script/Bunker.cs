using UnityEngine;

public class Bunker : MonoBehaviour
{
    public int health = 5;

    private void OnTriggerEnter2D(
        Collider2D other
    )
    {
        if (
            other.CompareTag("Bullet") ||
            other.CompareTag("EnemyBullet")
        )
        {
            health--;

            Destroy(other.gameObject);

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
