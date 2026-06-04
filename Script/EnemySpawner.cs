using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform enemyParent;

    void Start()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Vector3 localPos = new Vector3(
                    col * 1.5f - 5.25f,
                    row * 1.2f,
                    0f
                );

                GameObject enemy =
                    Instantiate(
                        enemyPrefab,
                        enemyParent
                    );

                enemy.transform.localPosition = localPos;
            }
        }
    }
}