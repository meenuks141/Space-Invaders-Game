using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "Score: 0";
    }

    public void AddScore(int amount)
    {
        score += amount;

        scoreText.text =
            "Score: " + score;
    }
}