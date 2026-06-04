using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyWave : MonoBehaviour
{
    public float speed = 1f;
    public float moveDownAmount = 0.5f;

    float direction = 1f;

    void Update()
    {
        transform.Translate(
            Vector2.right *
            direction *
            speed *
            Time.deltaTime
        );

        if (transform.position.x >= 5f)
        {
            direction = -1f;
            transform.position +=
                Vector3.down * moveDownAmount;
        }

        if (transform.position.x <= -5f)
        {
            direction = 1f;
            transform.position +=
                Vector3.down * moveDownAmount;
        }

        int enemiesLeft = transform.childCount;

        speed = 1f + (24 - enemiesLeft) * 0.1f;

        if (transform.position.y < -4f)
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }
    }
}