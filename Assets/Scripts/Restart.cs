using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Score Score;

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        Score.ResetScore();
    }
}
