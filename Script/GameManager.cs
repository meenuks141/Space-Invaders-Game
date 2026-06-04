using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text livesText;

    int lives = 3;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        livesText.text = "Lives: " + lives;
    }

    public void LoseLife()
    {
        lives--;

        livesText.text = "Lives: " + lives;

        if (lives <= 0)
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }
    }
}
