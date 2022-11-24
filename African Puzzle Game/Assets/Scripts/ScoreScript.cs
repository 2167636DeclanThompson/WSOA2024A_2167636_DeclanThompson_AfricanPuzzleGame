using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text playerScoreDisplay;
    public Text highScoreDisplay;
    public int playerScore;
    public int highScore;

    public void PlayerScored(int playerID)
    {
        if (playerID == 1)
        {
            playerScore++;
        }
        UpdateScore();
        {

        }
    }

    private void Start()
    {
        highScoreDisplay.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        UpdateScore();
    }
    private void UpdateScore()
    {
        playerScoreDisplay.text = playerScore.ToString();

        
    }
}
