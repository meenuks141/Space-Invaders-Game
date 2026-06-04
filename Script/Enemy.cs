using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyBulletPrefab;

    void Start()
    {
        InvokeRepeating(
            nameof(Shoot),
            Random.Range(2f, 4f),
            Random.Range(3f, 6f)
        );
    }

    void Shoot()
    {
        // Only some shooting attempts succeed
        if (Random.value > 0.25f)
            return;

        if (enemyBulletPrefab != null)
        {
            Instantiate(
                enemyBulletPrefab,
                transform.position,
                Quaternion.identity
            );
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);

            ScoreManager.instance.AddScore(10);

            CancelInvoke();

            Destroy(gameObject);
        }
    }
}