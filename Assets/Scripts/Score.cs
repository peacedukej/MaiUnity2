using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text ScoreText;
    public int score;

    void Start()
    {
        score = 0;
    }


    void UpdateScore()
    {
        score = Mathf.FloorToInt(Time.time * 10);
        ScoreText.text = "Score: " + score;
    }



    void Update()
    {
        UpdateScore();
    }
}
