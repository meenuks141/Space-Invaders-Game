using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(
            Vector2.up * speed * Time.deltaTime
        );

        if (transform.position.y > 6f)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        PlayerController player =
            FindFirstObjectByType<PlayerController>();

        if (player != null)
        {
            player.currentBullet = null;
        }
    }
}