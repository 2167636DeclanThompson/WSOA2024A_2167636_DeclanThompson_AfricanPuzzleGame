using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public ScoreScript scoreScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scoreScript.playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreScript.playerScore);
            scoreScript.highScoreDisplay.text = scoreScript.playerScore.ToString();
            scoreScript.highScore = scoreScript.playerScore;
        }

        if (scoreScript.playerScore < scoreScript.highScore)
        {
            PlayerPrefs.SetInt("HighScore", scoreScript.playerScore);
            scoreScript.highScoreDisplay.text = scoreScript.playerScore.ToString();
            scoreScript.highScore = scoreScript.playerScore;
        }

        SceneManager.LoadScene(4);
    }
}
