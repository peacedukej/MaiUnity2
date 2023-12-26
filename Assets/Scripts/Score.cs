using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int scoreCount;

    void Start()
    {
        scoreCount = 0;
        ScoreText.text = "Score: " + scoreCount;
    }

    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreCount = Mathf.FloorToInt(Time.time * 10);
        ScoreText.text = "Score: " + scoreCount;
    }

    public void ResetScore()
    {
        scoreCount = 0;
        ScoreText.text = "Score: " + scoreCount;
    }

    public int GetScore()
    {
        return scoreCount;
    }
}
