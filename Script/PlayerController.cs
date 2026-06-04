using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;

    public GameObject bulletPrefab;
    public Transform firePoint;

    public GameObject currentBullet;

    void Update()
    {
        float move =
            Input.GetAxis("Horizontal");

        transform.Translate(
            Vector2.right *
            move *
            speed *
            Time.deltaTime
        );

        Vector3 pos =
            transform.position;

        pos.x = Mathf.Clamp(
            pos.x,
            -7f,
            7f
        );

        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (currentBullet == null)
        {
            currentBullet =
                Instantiate(
                    bulletPrefab,
                    firePoint.position,
                    Quaternion.identity
                );
        }
    }

    private void OnTriggerEnter2D(
        Collider2D other
    )
    {
        if (other.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);

            GameManager.instance.LoseLife();
        }
    }
}